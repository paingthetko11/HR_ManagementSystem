using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeDailyReportDetail
{
    public long ReportId { get; set; }

    public long TitleId { get; set; }

    public string? Reporting { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployeeDailyReport Report { get; set; } = null!;

    public virtual HrDailyReportTitle Title { get; set; } = null!;
}
