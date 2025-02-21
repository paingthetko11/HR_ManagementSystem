using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;
            
        [HttpGet]
        [EndpointSummary("Get all State")]

        public async Task<IActionResult> GetStateAsync()
        {
            List<HrState> state = await _context.HrStates.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = state,
                Message = "sucessfully state found"
            });
        }

        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]

        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            HrState? state = await _context.HrStates.FirstOrDefaultAsync(x => x.StateId == id);

            if (state == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "State Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = state,
                    Message = "State found"
                });
            }
        }
        [HttpPost]

        public async Task<IActionResult> CreateAsync([FromBody] HrState state)
        {
            if (await _context.HrStates.AnyAsync(x => x.StateId == state.StateId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " State Not Found "

                });
            }

            _context.HrStates.Add(state);
            return await _context.SaveChangesAsync() > 0

            ? Created("api/state", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status201Created,
                Data = state,
                Message = "Sucessfully Created"
            })
            : BadRequest(new DefaultResponseModel()
            {
                Success = false,
                Code = StatusCodes.Status400BadRequest,
                Data = null,
                Message = " State Not Found "
            });
        }
        [HttpPut("{id}")]
        [EndpointSummary("Update an State")]
        public async Task<IActionResult> UpdateHrState(int id, [FromBody] HrState state)
        {
            HrState? existingState = await _context.HrStates.FirstOrDefaultAsync(x => x.StateId == state.StateId);
            if (existingState == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }
            
            existingState.StateName = state.StateName;
            existingState.StateNameMm = state.StateNameMm;
            _context.HrStates.Update(existingState);

            return _context.SaveChanges() > 0
                ? Created("api/state/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status400BadRequest,
                    Data = state,
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
        [EndpointSummary("Delete a State by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrState? state = await _context.HrStates.FirstOrDefaultAsync(x => x.StateId == id);

            if (state == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "State not found"
                });
            }

            _context.HrStates.Remove(state);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully deleted state"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete state"
                });
        }

    }
}


