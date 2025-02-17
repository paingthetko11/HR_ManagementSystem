using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrPaySlip
{
    public string PayslipId { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public DateOnly? PaidOn { get; set; }

    public double? Salary { get; set; }

    public double? AllowanceAmt { get; set; }

    public double? DeductionAmt { get; set; }

    public double? NetAmt { get; set; }

    public bool? IsTransferBankAccount { get; set; }

    public string? BankAccountNo { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrEmployeeAllowance> HrEmployeeAllowances { get; set; } = new List<HrEmployeeAllowance>();

    public virtual ICollection<HrEmployeeDeduction> HrEmployeeDeductions { get; set; } = new List<HrEmployeeDeduction>();
}
