using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownshipController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [EndpointSummary("Get all Townships")]

        public async Task<IActionResult> GetStateAsync()
        {
            List<HrTownship> state = await _context.HrTownships.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = state,
                Message = "sucessfully Township found"
            });
        }
        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]

        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            HrTownship? township = await _context.HrTownships.FirstOrDefaultAsync(x => x.TownshipId == id);

            if (township == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Township Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = township,
                    Message = "Township found"
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HrTownship township)
        {
            if (await _context.HrTownships.AnyAsync(x => x.TownshipId == township.TownshipId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Township Already Exist! "
                });
            }
            _context.HrTownships.Add(township);
            return await _context.SaveChangesAsync() > 0

            ? Created("api/township", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status201Created,
                Data = township,
                Message = "Sucessfully Created"
            })
            : BadRequest(new DefaultResponseModel()
            {
                Success = false,
                Code = StatusCodes.Status400BadRequest,
                Data = null,
                Message = " Townships Not Found "
            });
        }
        [HttpPut("{id}")]
        [EndpointSummary("Update an Township")]
        public async Task<IActionResult> UpdateHrTownship(int id, [FromBody] HrTownship township)
        {
            HrTownship? existingTownship = await _context.HrTownships.FirstOrDefaultAsync(x => x.TownshipId == township.TownshipId);
            if (existingTownship == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingTownship.TownshipName = township.TownshipName;
            existingTownship.TownshipNameMm = township.TownshipNameMm;
            _context.HrTownships.Update(existingTownship);


            return _context.SaveChanges() > 0
                ? Created("api/township/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status400BadRequest,
                    Data = township,
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
        [EndpointSummary("Delete a Township by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrTownship? township = await _context.HrTownships.FirstOrDefaultAsync(x => x.TownshipId == id);
            if (township == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Township not found"
                });
            }

            _context.HrTownships.Remove(township);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully deleted township"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete township"
                });
        }
    }
}
