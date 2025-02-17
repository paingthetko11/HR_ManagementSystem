using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrJobApplicant
{
    public long ApplyId { get; set; }

    public long JobId { get; set; }

    public DateTime ApplyDate { get; set; }

    public string? FullName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Qualification { get; set; }

    public string? Education { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Docs { get; set; }

    public string? EmployeeId { get; set; }

    public string? CompanyId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual HrJobOpening Job { get; set; } = null!;
}
