using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrStreet
{
    public int StreetId { get; set; }

    public string? StreetName { get; set; }

    public string? StreetNameMm { get; set; }

    public int TownshipId { get; set; }

    public string? TownshipName { get; set; }

    public string? TownshipNameMm { get; set; }

    public int StateId { get; set; }

    public string? StateName { get; set; }

    public string? StateNameMm { get; set; }

    public double? Lat { get; set; }

    public double? Long { get; set; }
}
