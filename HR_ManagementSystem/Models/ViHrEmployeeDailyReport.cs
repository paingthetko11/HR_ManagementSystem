using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployeeDailyReport
{
    public long ReportId { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? EmployeeId { get; set; }

    public string? UserName { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }
}
