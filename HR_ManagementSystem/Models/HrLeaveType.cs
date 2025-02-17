using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrLeaveType
{
    public long LeaveTypeId { get; set; }

    public long LeaveGroupId { get; set; }

    public string LeaveName { get; set; } = null!;

    public string? LeaveDescription { get; set; }

    public int LeaveEntitlement { get; set; }

    public int NoOfDaysAllowed { get; set; }

    public string CompanyId { get; set; } = null!;

    public bool IsDeduct { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrLeaveGroup LeaveGroup { get; set; } = null!;
}
