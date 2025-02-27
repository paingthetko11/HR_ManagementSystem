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
        [HttpGet]
        [EndpointSummary("Get all Compaany")]

        public async Task<IActionResult> GetComapnyAsync()
        {
            List<HrCompany> street = await _context.HrCompanies.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = street,
                Message = "Sucessfully Company found"
            });
        }
        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]
        public async Task<IActionResult> GetbyIdAsync(string id)
        {
            HrCompany? companies = await _context.HrCompanies.FirstOrDefaultAsync(x => x.CompanyId == id);

            if (companies == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Company Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = companies,
                    Message = "Company found"
                });
            }
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
    }
}
