using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeBacker
{
    public long BackerId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? Relative { get; set; }

    public string? Nrc { get; set; }

    public string? Phone { get; set; }

    public string? DetailAddress { get; set; }

    public string? Occupation { get; set; }

    public string? File1 { get; set; }

    public string? File2 { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;
}
