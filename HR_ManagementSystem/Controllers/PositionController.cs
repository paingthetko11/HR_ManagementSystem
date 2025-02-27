using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [EndpointSummary("Get all Position")]

        public async Task<IActionResult> GetAllowanceAsync()
        {
            List<HrPosition> street = await _context.HrPositions.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = street,
                Message = "sucessfully Position found"
            });
        }
        [HttpGet("{id}")]
        [EndpointSummary("Get By Id")]

        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            HrPosition? position = await _context.HrPositions.FirstOrDefaultAsync(x => x.PositionId == id);

            if (position == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Position Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = position,
                    Message = "Position found"
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HrPosition position)
        {
            if (await _context.HrPositions.AnyAsync(x => x.PositionId == position.PositionId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "Position id already exist"
                });
            }

            _ = _context.HrPositions.Add(position);
            _ = await _context.SaveChangesAsync();

            return Created("api/Company", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = position,
                Message = "Successfully created"
            });
        }
        [HttpPut("{id}")]
        [EndpointSummary("Update an Position")]
        public async Task<IActionResult> UpdateHrPosition(string id, [FromBody] HrPosition position)
        {
            HrPosition? existingPosition = await _context.HrPositions.FirstOrDefaultAsync(x => x.PositionId == id);
            if (existingPosition == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingPosition.PositionId = position.PositionId;
            existingPosition.DeptId = position.DeptId;
            existingPosition.PositionName = position.PositionName;
            existingPosition.Status = position.Status;
            existingPosition.CreatedOn = position.CreatedOn;
            existingPosition.CreatedBy = position.CreatedBy;
            existingPosition.UpdatedOn = position.UpdatedOn;
            existingPosition.UpdatedBy = position.UpdatedBy;
            existingPosition.DeletedOn = position.DeletedOn;
            existingPosition.DeletedBy = position.DeletedBy;
            existingPosition.Remark = position.Remark;
            existingPosition.Dept = position.Dept;

            
        }
            [HttpDelete("{id}")]
        [EndpointSummary("Delete a Allowance by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrPosition? position = await _context.HrPositions.FirstOrDefaultAsync(x => x.PositionId == id);

            if (position == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Allowance not found"
                });
            }
            _ = _context.HrPositions.Remove(position);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully   deleted Position"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Position"
                });
        }

    }
}

