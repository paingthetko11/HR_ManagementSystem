using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrNotificationToken
{
    public string UserId { get; set; } = null!;

    public string Device { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
