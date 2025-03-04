using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrDeduction
{
    public long DeductionId { get; set; }

    public string CompanyId { get; set; } = null!;

    public long BranchId { get; set; }

    public long DeptId { get; set; }

    public string DeductionName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDefault { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    //public virtual ICollection<HrEmployeeDeduction> HrEmployeeDeductions { get; set; } = new List<HrEmployeeDeduction>();

    //public virtual ICollection<HrRule> HrRules { get; set; } = new List<HrRule>();
}
