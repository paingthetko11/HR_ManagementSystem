using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeAllowance
{
    public long EmpAllowanceId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public long AllowanceId { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public double? Amount { get; set; }

    public DateTime? EfficetiveDate { get; set; }

    public bool Status { get; set; }

    public string? PaySlipId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual HrPaySlip? PaySlip { get; set; }
}
