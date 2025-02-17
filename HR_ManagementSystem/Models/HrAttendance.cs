using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrAttendance
{
    public long AttendId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public int LogType { get; set; }

    public DateTime AttendLog { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public int LateMins { get; set; }

    public int EarlyLeaveMins { get; set; }

    public int Othour { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;
}
