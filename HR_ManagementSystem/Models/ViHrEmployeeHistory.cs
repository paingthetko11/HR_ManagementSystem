using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployeeHistory
{
    public long HistoryId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long? PositionId { get; set; }

    public long? PromotionPositionId { get; set; }

    public string? PositionName { get; set; }

    public string? PromotionPositionName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public double? PreviousSalary { get; set; }

    public double? NewSalary { get; set; }

    public long? PreviousDeptId { get; set; }

    public string? PreviousDeptName { get; set; }

    public long? NewDeptId { get; set; }

    public string? NewDeptName { get; set; }

    public long? PreviousBranchId { get; set; }

    public string? PreviousBranchName { get; set; }

    public long? NewBranchId { get; set; }

    public string? NewBranchName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
