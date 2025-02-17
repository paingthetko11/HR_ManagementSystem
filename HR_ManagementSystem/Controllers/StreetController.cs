using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreetController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [EndpointSummary("Get all Street")]

        public async Task<IActionResult> GetStateAsync()
        {
            List<HrStreet> street = await _context.HrStreets.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = street,
                Message = "sucessfully Street found"
            });
        }
        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]
        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            HrStreet? street = await _context.HrStreets.FirstOrDefaultAsync(x => x.StreetId == id);

            if (street == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Street Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = street,
                    Message = "Street found"
                });
            }
        }

        [HttpGet("StreetPagination")]
        [EndpointSummary("Get Street By Pagination")]
        [EndpointDescription("Get Street By Pagination")]

        public async Task<IActionResult> GetStateByPagination(int page, int pagesize)
        {
            int totalStreets = await _context.HrStreets.CountAsync();
            List<HrStreet>? streets = await _context.HrStreets
                .Skip((page - 1) * pagesize)
                .Take(pagesize)
                .ToListAsync();
            return streets != null && streets.Count > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Message = "Sucessfully Pagination"
                })
                : NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Message = "Failed To Pagination"
                });
        }

        [HttpPost]
        [EndpointSummary("Create an Street")]
        public async Task<IActionResult> CreateAsync([FromBody] HrStreet street)
        {
            if (await _context.HrStreets.AnyAsync(x => x.StreetId == street.StreetId))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Street Already Exist! "
                });
            }
            _context.HrStreets.Add(street);
            return await _context.SaveChangesAsync() > 0

            ? Created("api/street", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status201Created,
                Data = street,
                Message = "Sucessfully Created"
            })
            : BadRequest(new DefaultResponseModel()
            {
                Success = false,
                Code = StatusCodes.Status400BadRequest,
                Data = null,
                Message = " Street Not Found "
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update an Street")]
        public async Task<IActionResult> UpdateHrStreet(int id, [FromBody] HrStreet street)
        {
            HrStreet? existingStreet = await _context.HrStreets.FirstOrDefaultAsync(x => x.StreetId == street.StreetId);
            if (existingStreet == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }
            existingStreet.StreetName = street.StreetName;
            existingStreet.StreetNameMm = street.StreetNameMm;
            existingStreet.TownshipId = street.TownshipId;
            existingStreet.Lat = street.Lat;
            existingStreet.Long = street.Long;
            _context.HrStreets.Update(existingStreet);


            return _context.SaveChanges() > 0
                ? Created("api/street/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status400BadRequest,
                    Data = street,
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
        [EndpointSummary("Delete a Street by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrStreet? street = await _context.HrStreets.FirstOrDefaultAsync(x => x.StreetId == id);
            if (street == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Street not found"
                });
            }

            _context.HrStreets.Remove(street);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully deleted street"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Street"
                });
        }

    }
}
