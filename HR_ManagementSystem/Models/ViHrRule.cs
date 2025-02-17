using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrRule
{
    public long RuleId { get; set; }

    public long DeductionId { get; set; }

    public string DeductionName { get; set; } = null!;

    public int CalculationType { get; set; }

    public int? FromRange { get; set; }

    public int? ToRange { get; set; }

    public double? Value { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long DeptId { get; set; }

    public string? DeptName { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
