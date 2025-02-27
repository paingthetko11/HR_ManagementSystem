using System.IO;
using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrBranchController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        //[HttpGet]
        //[EndpointSummary("Get all Branches")]

        //public async Task<IActionResult> GetAllowanceAsync()
        //{
        //    List<HrBranch> branches = await _context.HrBranches.ToListAsync();
        //    return Ok(new DefaultResponseModel()
        //    {
        //        Success = true,
        //        Code = StatusCodes.Status200OK,
        //        Data = branches,
        //        Message = "sucessfully Allowance found"
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
                Data = await _context.ViHrCompanies.Where(x => !x.DeletedOn.HasValue).ToListAsync(),
            });
        }
        //[HttpGet("{id}")]
        //[EndpointSummary("Get by ID")]
        //public async Task<IActionResult> GetbyIdAsync(long id)
        //{
        //    //HrBranch? branches = await _context.HrBranches.FirstOrDefault(x => x.BranchId == id);
        //    HrBranch? branches = await _context.HrBranches.FirstOrDefaultAsync(x => x.BranchId == id);


        //    if (branches == null)
        //    {
        //        return NotFound(new DefaultResponseModel()
        //        {
        //            Success = false,
        //            Code = StatusCodes.Status404NotFound,
        //            Data = null,
        //            Message = "Branch Not found"
        //        });
        //    }
        //    else
        //    {
        //        return Ok(new DefaultResponseModel()
        //        {
        //            Success = true,
        //            Code = StatusCodes.Status200OK,
        //            Data = branches,
        //            Message = "Branch found"
        //        });
        //    }
        //}
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ViHrBranch), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DefaultResponseModel), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ViHrBranch>> GetByIdAsync(long id)
        {
            var ViBranch = await _context.ViHrBranches.Where(x => x.BranchId == id).ToListAsync();
            return ViBranch != null
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = ViBranch,
                    Message = "Branch data found."
                })
                : NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Message = "Branch data not found."
                });
        }
        [HttpGet("by-companyId")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ViHrBranch), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DefaultResponseModel), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ViHrBranch>> GetByDeptIdAsync(string companyId)
        {
            //var ViPosition = await _context.ViHrPositions.Where(x => x.PositionId == id).ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Code = StatusCodes.Status200OK,
                Success = true,
                Data = await _context.ViHrBranches.Where(x => x.CompanyId == companyId && !x.DeletedOn.HasValue).ToListAsync()
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update an Branch")]
        public async Task<IActionResult> UpdateHrBranch(int id, [FromBody] HrBranch branch)
        {
            HrBranch? existingBranch = await _context.HrBranches.FirstOrDefaultAsync(x => x.BranchId == id);
            if (existingBranch == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingBranch.BranchId = branch.BranchId;
            existingBranch.BranchName = branch.BranchName;
            existingBranch.CompanyId = branch.CompanyId;
            existingBranch.ContactPerson = branch.ContactPerson;
            existingBranch.PrimaryPhone = branch.PrimaryPhone;
            existingBranch.OtherPhone = branch.OtherPhone;
            existingBranch.Email = branch.Email;
            existingBranch.HouseNo = branch.HouseNo;
            existingBranch.StateId = branch.StateId;
            existingBranch.StreetName = branch.StreetName;
            existingBranch.TownshipId = branch.TownshipId;
            existingBranch.StateId = branch.StateId;
            existingBranch.Photo = branch.Photo;
            existingBranch.IsDefault = branch.IsDefault;
            existingBranch.IsAutoDeduction = branch.IsAutoDeduction;
            existingBranch.Status = branch.Status;
            existingBranch.CreatedOn = branch.CreatedOn;
            existingBranch.CreatedBy = branch.CreatedBy;
            existingBranch.UpdatedOn = branch.UpdatedOn;
            existingBranch.UpdatedBy = branch.UpdatedBy;
            existingBranch.DeletedOn = branch.DeletedOn;
            existingBranch.DeletedBy = branch.DeletedBy;
            existingBranch.Remark = branch.Remark;
            existingBranch.Company = branch.Company;
            existingBranch.HrDepartments = branch.HrDepartments;
            existingBranch.HrLeaveGroups = branch.HrLeaveGroups;
            _ = _context.HrBranches.Update(existingBranch);

            return _context.SaveChanges() > 0
                ? Created("api/HrBranch/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingBranch,
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
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrBranch? branch = await _context.HrBranches.FirstOrDefaultAsync(x => x.BranchId == id);

            if (branch == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Branch not found"
                });
            }

            _ = _context.HrBranches.Remove(branch);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully   deleted Branch"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Branch"
                });
        }

    }
}
