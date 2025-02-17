using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeEducation
{
    public long EducationHistoryId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public string? Major { get; set; }

    public string InstitutionName { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? Gpa { get; set; }

    public string? Description { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;
}
