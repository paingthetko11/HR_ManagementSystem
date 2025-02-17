using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeRequest
{
    public long RequestId { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? RequestType { get; set; }

    public long? RelatedTypeId { get; set; }

    public bool IsResign { get; set; }

    public DateOnly? RequestResignDate { get; set; }

    public double? RequestAmount { get; set; }

    public string? Description { get; set; }

    public string? File1 { get; set; }

    public string? File2 { get; set; }

    public string? File3 { get; set; }

    public int? RequestStatus { get; set; }

    public string? ReplyBy { get; set; }

    public DateTime? ReplyDate { get; set; }

    public string? ReplyRemark { get; set; }

    public virtual HrEmployee? Employee { get; set; }
}
