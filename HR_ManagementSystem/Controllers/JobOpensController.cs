using HR_ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOpensController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        #region CRUD Operation

        [HttpGet]
        [EndpointSummary("Gell All JobOpening")]
        public async Task<IActionResult> GetAllJobOpenAsync()
        {
            List<ViHrJobOpening> street = await _context.ViHrJobOpenings.ToListAsync();
            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = street,
                Message = "sucessfully Job Opening found"
            });
        }

        [HttpGet("{id}")]
        [EndpointSummary("Get By Id")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            ViHrJobOpening? opening = await _context.ViHrJobOpenings.FirstOrDefaultAsync(x => x.Id == id);
            return opening == null
                ? NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Job Opening Not found"
                })
                : Ok(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = opening,
                    Message = "JobOpening found"
                });
        }

        [HttpPost]
        [EndpointSummary("Create JobOpening")]
        public async Task<IActionResult> CreateAsync([FromBody] HrJobOpening opening)
        {
            if (await _context.HrJobOpenings.AnyAsync(x => x.Id == opening.Id))
            {
                return BadRequest(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = "Job Opening id already exist"
                });
            }

            _ = _context.HrJobOpenings.Add(opening);
            int res = await _context.SaveChangesAsync();

            return res > 0 ?
                Created("api/JobOpens", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = opening,
                    Message = "Successfully created"
                })
                : BadRequest(new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status400BadRequest,
                    Data = opening,
                    Message = "failed to created"
                });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update Job Opening")]
        public async Task<IActionResult> UpdateHrJobOpening(long id, [FromBody] HrJobOpening opening)
        {
            HrJobOpening? existingJobOpening = await _context.HrJobOpenings.FirstOrDefaultAsync(x => x.Id == id);
            if (existingJobOpening == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status400BadRequest,
                    Data = null,
                    Message = " Failed To Updated "
                });
            }
            existingJobOpening.Id = opening.Id;
            existingJobOpening.Title = opening.Title;
            existingJobOpening.Description = opening.Description;
            existingJobOpening.NoOfApplicants = opening.NoOfApplicants;
            existingJobOpening.StartOn = opening.StartOn;
            existingJobOpening.EndOn = opening.EndOn;
            existingJobOpening.CompanyId = opening.CompanyId;
            existingJobOpening.BranchId = opening.BranchId;
            existingJobOpening.DeptId = opening.DeptId;
            existingJobOpening.PositionId = opening.PositionId;
            existingJobOpening.OpeningStatus = opening.OpeningStatus;
            existingJobOpening.CreatedOn = opening.CreatedOn;
            existingJobOpening.CreatedBy = opening.CreatedBy;
            existingJobOpening.UpdatedOn = opening.UpdatedOn;
            existingJobOpening.UpdatedBy = opening.UpdatedBy;
            existingJobOpening.DeletedOn = opening.DeletedOn;
            existingJobOpening.DeletedBy = opening.DeletedBy;
            existingJobOpening.Remark = opening.Remark;

            //_ = _context.HrJobOpenings.Update(existingJobOpening);
            _context.Entry(existingJobOpening).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0
                ? Created("api/JobOpens/{id}", new DefaultResponseModel()
                {
                    Success = true,
                    Code = StatusCodes.Status200OK,
                    Data = existingJobOpening,
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
        [EndpointSummary("Delete Job Opening")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            HrJobOpening? opening = await _context.HrJobOpenings.FirstOrDefaultAsync(x => x.Id == id);
            if (opening == null)
            {
                return NotFound(new DefaultResponseModel()
                {
                    Success = false,
                    Code = StatusCodes.Status404NotFound,
                    Data = null,
                    Message = "Job Opening not found"
                });
            }
            _ = _context.HrJobOpenings.Remove(opening);
            return await _context.SaveChangesAsync() > 0
               ? Ok(new DefaultResponseModel()
               {
                   Success = true,
                   Code = StatusCodes.Status200OK,
                   Data = null,
                   Message = "Successfully   deleted Job Opening"
               })
               : StatusCode(StatusCodes.Status500InternalServerError, new DefaultResponseModel()
               {
                   Success = false,
                   Code = StatusCodes.Status500InternalServerError,
                   Data = null,
                   Message = "Failed to delete Job Openning"
               });
        }

        #endregion

        [HttpGet("by")]
        public async Task<IActionResult> GetByComoanyIdAsync(string companyid, long? branchid, long? depId, long? positionId)
        {
            IReadOnlyList<ViHrJobOpening>? openings = [];
            if (!string.IsNullOrEmpty(companyid) && branchid.HasValue && depId.HasValue && positionId.HasValue)
            {
                openings = await _context.ViHrJobOpenings.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid && x.DeptId == depId).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid) && branchid.HasValue && depId.HasValue)
            {
                openings = await _context.ViHrJobOpenings.Where(x =>
                !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid && x.DeptId == depId).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid) && branchid.HasValue)
            {
                openings = await _context.ViHrJobOpenings.Where(x =>
               !x.DeletedOn.HasValue && x.CompanyId == companyid && x.BranchId == branchid).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(companyid))
            {
                openings = await _context.ViHrJobOpenings.Where(x =>
               !x.DeletedOn.HasValue && x.CompanyId == companyid).ToListAsync();
            }

            return Ok(new DefaultResponseModel()
            {
                Success = true,
                Code = StatusCodes.Status200OK,
                Data = openings
            });
        }
    }
}
