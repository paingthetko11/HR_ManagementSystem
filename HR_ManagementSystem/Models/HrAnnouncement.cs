using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrAnnouncement
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Img { get; set; }

    public string? CompanyId { get; set; }

    public long? DeptId { get; set; }

    public string? EmployeeId { get; set; }

    public DateOnly? StartOn { get; set; }

    public DateOnly? EndOn { get; set; }

    public bool IsNotify { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
