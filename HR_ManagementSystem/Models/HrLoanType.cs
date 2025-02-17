using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrLoanType
{
    public long LoanTypeId { get; set; }

    public string? LoanTypeName { get; set; }

    public string? LoanDescription { get; set; }

    public string? CompanyId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrCompany? Company { get; set; }
}
