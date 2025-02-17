using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrAllowance
{
    public long AllowanceId { get; set; }

    public string? AllowanceName { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public long? BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public string? Description { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
