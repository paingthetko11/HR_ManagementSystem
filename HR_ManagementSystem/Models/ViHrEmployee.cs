using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class ViHrEmployee
{
    public string EmployeeId { get; set; } = null!;

    public string? Code { get; set; }

    public string? UserName { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? Nrc { get; set; }

    public string? Qualification { get; set; }

    public string? Education { get; set; }

    public string? PhoneNumber { get; set; }

    public string? OtherPhone { get; set; }

    public string? Email { get; set; }

    public string? HouseNo { get; set; }

    public int? StreetId { get; set; }

    public string? StreetName { get; set; }

    public int? TownshipId { get; set; }

    public string? TownshipName { get; set; }

    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public string? Profile { get; set; }

    public string? FingerPrint { get; set; }

    public string? FingerPrintNo { get; set; }

    public string? DrivingLicense { get; set; }

    public bool IsSignAgreement { get; set; }

    public DateOnly? ResignDate { get; set; }

    public double Salary { get; set; }

    public string? Currency { get; set; }

    public double LoanAmt { get; set; }

    public int Status { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public long BranchId { get; set; }

    public string? BranchName { get; set; }

    public long? DeptId { get; set; }

    public string? DeptName { get; set; }

    public long? PositionId { get; set; }

    public string? PositionName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public string? RoleName { get; set; }
}
