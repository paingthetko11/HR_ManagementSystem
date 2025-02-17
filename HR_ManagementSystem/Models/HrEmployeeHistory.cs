using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeHistory
{
    public long HistoryId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public long? PositionId { get; set; }

    public long? PromotionPositionId { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public double? PreviousSalary { get; set; }

    public double? NewSalary { get; set; }

    public long? PreviousDeptId { get; set; }

    public long? NewDeptId { get; set; }

    public long? PreviousBranchId { get; set; }

    public long? NewBranchId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;
}
