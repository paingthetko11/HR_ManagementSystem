using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeDailyReport
{
    public long ReportId { get; set; }

    public string? EmployeeId { get; set; }

    public DateTime? ReportDate { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrEmployeeDailyReportDetail> HrEmployeeDailyReportDetails { get; set; } = new List<HrEmployeeDailyReportDetail>();
}
