using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployeeDeduction
{
    public long EmpDeductionId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? UserName { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Profile { get; set; }

    public long DeductionId { get; set; }

    public string? DeductionName { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public double? Amount { get; set; }

    public DateTime? EfficetiveDate { get; set; }

    public string? OtherPhone { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public bool Status { get; set; }

    public string? PaySlipId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
