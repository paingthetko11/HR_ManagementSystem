using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrDailyReportTitle
{
    public long ReportTitleId { get; set; }

    public string? ReportTitle { get; set; }

    public string CompanyId { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<HrEmployeeDailyReportDetail> HrEmployeeDailyReportDetails { get; set; } = new List<HrEmployeeDailyReportDetail>();
}
