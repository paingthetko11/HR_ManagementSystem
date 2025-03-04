using System.IO;
using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeductionController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;


        [HttpGet]
        [EndpointSummary("Get all deduction")]

        public async Task<IActionResult> GetDeductionAsync()
        {
            List<ViHrDeduction>deductions = await _context.ViHrDeductions.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = deductions,
                Message = "sucessfully Deduction found"
            });
        }


        [HttpPost]
        [EndpointSummary("Create Deduction")]

        public async Task<IActionResult> CreateAsync([FromBody] HrDeduction deduction)
        {

            if (await _context.ViHrDeductions.AnyAsync(x => x.DeductionId == deduction.DeductionId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "deduction id already exist"
                });
            }

            _ = _context.HrDeductions.Add(deduction);
            _ = await _context.SaveChangesAsync();

            return Created("api/deduction", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = deduction,
                Message = "Successfully created"
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update an deduction")]
        public async Task<IActionResult> UpdateHrDeduction(int id, [FromBody] HrDeduction deduction)
        {
            HrDeduction? existingDeduction = await _context.HrDeductions.FirstOrDefaultAsync(x => x.DeductionId == id);
            if (existingDeduction == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingDeduction.DeductionId = deduction.DeductionId;
            existingDeduction.CompanyId = deduction.CompanyId;
            existingDeduction.BranchId = deduction.BranchId;
            existingDeduction.DeptId = deduction.DeptId;
            existingDeduction.DeductionName = deduction.DeductionName;
            existingDeduction.Description = deduction.Description;
            existingDeduction.IsDefault = deduction.IsDefault;
            existingDeduction.Status = deduction.Status;
            existingDeduction.UpdatedBy = "Admin";
            existingDeduction.UpdatedOn = DateTime.Now;


            _ = _context.HrDeductions.Update(existingDeduction);

            return _context.SaveChanges() > 0
                ? Created("api/deduction/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingDeduction,
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
