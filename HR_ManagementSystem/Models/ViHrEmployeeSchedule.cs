using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployeeSchedule
{
    public long ScheduleId { get; set; }

    public string? EmployeeId { get; set; }

    public string? UserName { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public bool? IsSunday { get; set; }

    public TimeOnly? _1BusinessDayStartHour { get; set; }

    public TimeOnly? _1BusinessDayEndHour { get; set; }

    public bool IsMonday { get; set; }

    public TimeOnly? _2BusinessDayStartHour { get; set; }

    public TimeOnly? _2BusinessDayEndHour { get; set; }

    public bool IsTuesday { get; set; }

    public TimeOnly? _3BusinessDayStartHour { get; set; }

    public TimeOnly? _3BusinessDayEndHour { get; set; }

    public bool IsWednesday { get; set; }

    public TimeOnly? _4BusinessDayStartHour { get; set; }

    public TimeOnly? _4BusinessDayEndHour { get; set; }

    public bool IsThursday { get; set; }

    public TimeOnly? _5BusinessDayStartHour { get; set; }

    public TimeOnly? _5BusinessDayEndHour { get; set; }

    public bool IsFriday { get; set; }

    public TimeOnly? _6BusinessDayStartHour { get; set; }

    public TimeOnly? _6BusinessDayEndHour { get; set; }

    public bool IsSaturday { get; set; }

    public TimeOnly? _7BusinessDayStartHour { get; set; }

    public TimeOnly? _7BusinessDayEndHour { get; set; }

    public bool IsCurrent { get; set; }

    public bool IsOtpaid { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }
}
