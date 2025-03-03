using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllowanceController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [EndpointSummary("Get all Allowance")]

        public async Task<IActionResult> GetAllowanceAsync()
        {
            List<HrAllowance> street = await _context.HrAllowances.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = street,
                Message = "sucessfully Allowance found"
            });
        }
        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]
        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            ViHrAllowance? allowance = await _context.ViHrAllowances.FirstOrDefaultAsync(x => x.AllowanceId == id);

            if (allowance == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Allowance Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = allowance,
                    Message = "Allowance found"
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HrAllowance allowrance)
        {
            if (await _context.HrAllowances.AnyAsync(x => x.AllowanceId == allowrance.AllowanceId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "Allowance id already exist"
                });
            }

            _ = _context.HrAllowances.Add(allowrance);
            _ = await _context.SaveChangesAsync();

            return Created("api/Allowance", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = allowrance,
                Message = "Successfully created"
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update an Allowance")]
        public async Task<IActionResult> UpdateHrPolicy(int id, [FromBody] HrAllowance allowance)
        {
            HrAllowance? existingAllowrance = await _context.HrAllowances.FirstOrDefaultAsync(x => x.AllowanceId == id);
            if (existingAllowrance == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingAllowrance.CompanyId = allowance.CompanyId;
            existingAllowrance.CompanyId = allowance.CompanyId;
            existingAllowrance.BranchId = allowance.BranchId;
            existingAllowrance.DeptId = allowance.DeptId;
            existingAllowrance.PositionId = allowance.PositionId;
            existingAllowrance.AllowanceName = allowance.AllowanceName;
            existingAllowrance.Description = allowance.Description;
            existingAllowrance.Status = allowance.Status;
            existingAllowrance.UpdatedBy = "Admin";
            existingAllowrance.UpdatedOn = DateTime.Now;

            _ = _context.HrAllowances.Update(existingAllowrance);

            return _context.SaveChanges() > 0
                ? Created("api/Allowance/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingAllowrance,
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
        [EndpointSummary("Delete a Allowance by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrAllowance? allowance = await _context.HrAllowances.FirstOrDefaultAsync(x => x.AllowanceId == id);

            if (allowance == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Allowance not found"
                });
            }
            _ = _context.HrAllowances.Remove(allowance);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully   deleted Allowance"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Allowance"
                });
        }

    }
}
