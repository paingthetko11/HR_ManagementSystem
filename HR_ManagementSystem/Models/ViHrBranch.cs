using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrBranch
{
    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? ContactPerson { get; set; }

    public string? PrimaryPhone { get; set; }

    public string? OtherPhone { get; set; }

    public string? Email { get; set; }

    public string? HouseNo { get; set; }

    public int? StreetId { get; set; }

    public string? StreetName { get; set; }

    public int? TownshipId { get; set; }

    public string? TownshipName { get; set; }

    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public string? Photo { get; set; }

    public bool IsDefault { get; set; }

    public bool IsAutoDeduction { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
