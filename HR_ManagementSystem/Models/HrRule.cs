using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrRule
{
    public long RuleId { get; set; }

    public long DeductionId { get; set; }

    public int CalculationType { get; set; }

    public int? FromRange { get; set; }

    public int? ToRange { get; set; }

    public double? Value { get; set; }

    public string CompanyId { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrDeduction Deduction { get; set; } = null!;
}
