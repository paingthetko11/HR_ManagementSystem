using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrBranch
{
    public long BranchId { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? BranchName { get; set; }

    public string? ContactPerson { get; set; }

    public string? PrimaryPhone { get; set; }

    public string? OtherPhone { get; set; }

    public string? Email { get; set; }

    public string? HouseNo { get; set; }

    public int? StreetId { get; set; }

    public string? StreetName { get; set; }

    public int? TownshipId { get; set; }

    public int? StateId { get; set; }

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

    public virtual HrCompany Company { get; set; } = null!;

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrLeaveGroup> HrLeaveGroups { get; set; } = new List<HrLeaveGroup>();
}
