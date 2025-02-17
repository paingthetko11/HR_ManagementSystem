using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrLeaveGroup
{
    public long LeaveGroupId { get; set; }

    public string? LeaveGroupName { get; set; }

    public string CompanyId { get; set; } = null!;

    public long BranchId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrBranch Branch { get; set; } = null!;

    public virtual HrCompany Company { get; set; } = null!;

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; set; } = new List<HrLeaveType>();
}
