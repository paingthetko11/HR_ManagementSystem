using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrActivityChange
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Changes { get; set; }

    public DateTime? ChangesOn { get; set; }

    public string? ChangesBy { get; set; }

    public string? ChangesState { get; set; }
}
