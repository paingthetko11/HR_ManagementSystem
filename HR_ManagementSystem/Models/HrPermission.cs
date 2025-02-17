using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrPermission
{
    public string UserId { get; set; } = null!;

    public string? Permission { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
