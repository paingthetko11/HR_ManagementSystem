using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrDepartment
{
    public long DeptId { get; set; }

    public long BranchId { get; set; }

    public string? DeptName { get; set; }

    public long? LeaveGroupId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrBranch Branch { get; set; } = null!;

    public virtual ICollection<HrPosition> HrPositions { get; set; } = new List<HrPosition>();

    public virtual HrLeaveGroup? LeaveGroup { get; set; }
}
