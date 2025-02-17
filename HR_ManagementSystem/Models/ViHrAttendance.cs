using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrAttendance
{
    public long AttendId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? UserName { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string Gender { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public int LogType { get; set; }

    public DateTime AttendLog { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public int LateMins { get; set; }

    public int EarlyLeaveMins { get; set; }

    public int Othour { get; set; }
}
