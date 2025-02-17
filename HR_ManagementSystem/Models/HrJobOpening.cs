using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrJobOpening
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int NoOfApplicants { get; set; }

    public DateOnly? StartOn { get; set; }

    public DateOnly? EndOn { get; set; }

    public string? CompanyId { get; set; }

    public long? BranchId { get; set; }

    public long? DeptId { get; set; }

    public long? PositionId { get; set; }

    public bool OpeningStatus { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<HrJobApplicant> HrJobApplicants { get; set; } = new List<HrJobApplicant>();
}
