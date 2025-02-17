using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployeeLeaveRequest
{
    public long RequestId { get; set; }

    public string? EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? RequestDate { get; set; }

    public long? RelatedTypeId { get; set; }

    public string? RelatedTypeName { get; set; }

    public string? Description { get; set; }

    public string? File1 { get; set; }

    public string? File2 { get; set; }

    public string? File3 { get; set; }

    public int? RequestStatus { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public string? ReplyBy { get; set; }

    public DateTime? ReplyDate { get; set; }

    public string? ReplyRemark { get; set; }
}
