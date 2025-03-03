using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;
        //[HttpGet]
        //[EndpointSummary("Get all Compaany")]

        //public async Task<IActionResult> GetComapnyAsync()
        //{
        //    List<HrCompany> street = await _context.HrCompanies.ToListAsync();
        //    return Ok(new DefaultResponseModel()
        //    {
        //        Success = true,
        //        Code = StatusCodes.Status200OK,
        //        Data = street,
        //        Message = "Sucessfully Company found"
        //    });
        //}
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<ViHrCompany>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = await _context.ViHrCompanies.Where(x => !x.DeletedOn.HasValue).ToListAsync()
            });
        }
        //[HttpGet("{id}")]
        //[EndpointSummary("Get by ID")]
        //public async Task<IActionResult> GetbyIdAsync(string id)
        //{
        //    HrCompany? companies = await _context.HrCompanies.FirstOrDefaultAsync(x => x.CompanyId == id);

        //    if (companies == null)
        //    {
        //        return NotFound(new DefaultResponseModel()
        //        {
        //            Success = false,
        //            Code = StatusCodes.Status404NotFound,
        //            Data = null,
        //            Message = "Company Not found"
        //        });
        //    }
        //    else
        //    {
        //        return Ok(new DefaultResponseModel()
        //        {
        //            Success = true,
        //            Code = StatusCodes.Status200OK,
        //            Data = companies,
        //            Message = "Company found"
        //        });
        //    }
        //}
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ViHrCompany), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DefaultResponseModel), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ViHrCompany>> GetByIdAsync(string id)
        {
            var ViCompany = await _context.ViHrCompanies.Where(x=>x.CompanyId==id).ToListAsync();
            return ViCompany != null
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = ViCompany,
                    Message = "Company data found."
                })
                : NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Message = "Company data not found."
                });
        }
        [HttpGet("by-CBDid")]
        public async Task<IActionResult> GetByCompanyAsync(string companyid, long? branchid, long? deptId)
        {
            IReadOnlyList<ViHrPosition>? position = [];

            // CompanyId, BranchId, DepartmentId
            if (!string.IsNullOrEmpty(companyid) && branchid.HasValue && deptId.HasValue)
            {
                position = await _context.ViHrPositions.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid && x.DeptId == deptId).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid) && branchid.HasValue)
            {
                position = await _context.ViHrPositions.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid))
            {
                position = await _context.ViHrPositions.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid).ToListAsync();
            }

            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = position,
            });
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HrCompany company)
        {
            if (await _context.HrCompanies.AnyAsync(x => x.CompanyId == company.CompanyId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "Company id already exist"
                });
            }

            _ = _context.HrCompanies.Add(company);
            _ = await _context.SaveChangesAsync();

            return Created("api/Company", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = company,
                Message = "Successfully created"
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update an Company")]
        public async Task<IActionResult> UpdateHrCompany(string id, [FromBody] HrCompany company)
        {
            HrCompany? existingCompany = await _context.HrCompanies.FirstOrDefaultAsync(x => x.CompanyId == id);
            if (existingCompany == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }
            existingCompany.CompanyId = company.CompanyId;
            existingCompany.CompanyName = company.CompanyName;
            existingCompany.JoinDate = company.JoinDate;
            existingCompany.LicenseNo = company.LicenseNo;
            existingCompany.ContactPerson = company.ContactPerson;
            existingCompany.PrimaryPhone = company.PrimaryPhone;
            existingCompany.OtherPhone = company.OtherPhone;
            existingCompany.Email = company.Email;
            existingCompany.HouseNo = company.HouseNo;
            existingCompany.StreetId = company.StreetId;
            existingCompany.StreetName = company.StreetName;
            existingCompany.TownshipId = company.TownshipId;
            existingCompany.StateId = company.StateId;
            existingCompany.Photo = company.Photo;
            existingCompany.Status = company.Status;
            existingCompany.CreatedOn = company.CreatedOn;
            existingCompany.CreatedBy = company.CreatedBy;
            existingCompany.UpdatedOn = company.UpdatedOn;
            existingCompany.UpdatedBy = company.UpdatedBy;
            existingCompany.DeletedOn = company.DeletedOn;

            _ = _context.HrCompanies.Update(existingCompany);

            return _context.SaveChanges() > 0
                ? Created("api/Company/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingCompany,
                    Message = " Sucessfully Updated"
                })
            : NotFound(new DefaultResponseModel()
            {
                Success = false,
                Code = StatusCodes.Status400BadRequest,
                Data = null,
                Message = " Failed To Updated "
            });
        }
        [HttpDelete("{id}")]
        [EndpointSummary("Delete a Branch by ID")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            HrCompany? company = await _context.HrCompanies.FirstOrDefaultAsync(x => x.CompanyId == id);

            if (company == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Compay not found"
                });
            }

            _ = _context.HrCompanies.Remove(company);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully   deleted Company"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Company"
                });
        }

    }
}
