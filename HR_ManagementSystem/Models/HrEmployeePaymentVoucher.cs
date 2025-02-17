using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeePaymentVoucher
{
    public string VoucherNo { get; set; } = null!;

    public DateTime VourcharDate { get; set; }

    public string EmployeeId { get; set; } = null!;

    public int? VoucherType { get; set; }

    public bool IsClearance { get; set; }

    public double Amount { get; set; }

    public double ClearnaceAmount { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
