using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<ViHrDepartment>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = await _context.ViHrDepartments.Where(x => !x.DeletedOn.HasValue).ToListAsync()

            });
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<ViHrDepartment>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DefaultResponseModel), StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ViHrDepartment>> GetByIdAsync(long id)
        {
            var viDepartment = await _context.ViHrDepartments.Where(x =>x.DeptId==id).ToListAsync();
            return viDepartment != null
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = viDepartment,
                    Message = "Department Data Found."
                })
                : NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Message = "Department Data Not Found."
                });
        }

        [HttpGet("by")]
        public async Task<IActionResult> GetByCompanyByBranchAsync(string companyid, long? branchid)
        {
            IReadOnlyList<ViHrDepartment>? department = [];

            // CompanyId, BranchId
            if (!string.IsNullOrEmpty(companyid) && branchid.HasValue)
            {
                department = await _context.ViHrDepartments.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid))
            {
                department = await _context.ViHrDepartments.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid).ToListAsync();
            }

            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = department,
            });
        }


    }
}
