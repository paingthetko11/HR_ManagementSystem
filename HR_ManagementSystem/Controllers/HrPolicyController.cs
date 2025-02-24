using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrPolicyController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        [EndpointSummary("Get all Policy")]
         
        public async Task<IActionResult> GetStateAsync()
        {
            List<HrPolicy> policy = await _context.HrPolicies.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = policy,
                Message = "sucessfully state found"
            });
        }

        [HttpGet("{id}")]
        [EndpointSummary("Get by ID")]

        public async Task<IActionResult> GetbyIdAsync(long id)
        {
            HrPolicy? policy = await _context.HrPolicies.FirstOrDefaultAsync(x => x.Id == id);

            if (policy == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Policy Not found"
                });
            }
            else
            {
                return Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = policy,
                    Message = "Policy found"
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] HrPolicy policy)
        {
            if (await _context.HrPolicies.AnyAsync(x => x.Id == policy.Id))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "policy id already exist"
                });
            }

            _ = _context.HrPolicies.Add(policy);
            _ = await _context.SaveChangesAsync();

            return Created("api/HrPolicy", new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = policy,
                Message = "Successfully created"
            });
        }
        [HttpPut("{id}")]
        [EndpointSummary("Update an Policy")]
        public async Task<IActionResult> UpdateHrPolicy(int id, [FromBody] HrPolicy policy)
        {
            HrPolicy? existingPolicy = await _context.HrPolicies.FirstOrDefaultAsync(x => x.Id == id);
            if (existingPolicy == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }

            existingPolicy.Title = policy.Title;
            existingPolicy.Description = policy.Description;
            existingPolicy.PolicyType = policy.PolicyType;
            existingPolicy.CompanyId = policy.CompanyId;
            _context.HrPolicies.Update(existingPolicy);

            return _context.SaveChanges() > 0
                ? Created("api/policy/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingPolicy,
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
        [EndpointSummary("Delete a Policy by ID")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrPolicy? policy = await _context.HrPolicies.FirstOrDefaultAsync(x => x.Id == id);

            if (policy == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "State not found"
                });
            }

            _context.HrPolicies.Remove(policy);

            return await _context.SaveChangesAsync() > 0
                ? Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = null,
                    Message = "Successfully   deleted Policy"
                })
                : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = "Failed to delete Policy"
                });
        }
    }
}
