using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeJobHistory
{
    public long JobHistoryId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? JobDescription { get; set; }

    public double? Salary { get; set; }

    public string? Location { get; set; }

    public string? SupervisorName { get; set; }

    public string? SupervisorContact { get; set; }

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
