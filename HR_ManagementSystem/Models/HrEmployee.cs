using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployee
{
    public string EmployeeId { get; set; } = null!;

    public string? Code { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? Nrc { get; set; }

    public string? Qualification { get; set; }

    public string? Education { get; set; }

    public string? OtherPhone { get; set; }

    public string? HouseNo { get; set; }

    public int? StreetId { get; set; }

    public string? StreetName { get; set; }

    public int? TownshipId { get; set; }

    public int? StateId { get; set; }

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

    public long BranchId { get; set; }

    public long? DeptId { get; set; }

    public long? PositionId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<HrAttendance> HrAttendances { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrEmployeeAllowance> HrEmployeeAllowances { get; set; } = new List<HrEmployeeAllowance>();

    public virtual ICollection<HrEmployeeBacker> HrEmployeeBackers { get; set; } = new List<HrEmployeeBacker>();

    public virtual ICollection<HrEmployeeDailyReport> HrEmployeeDailyReports { get; set; } = new List<HrEmployeeDailyReport>();

    public virtual ICollection<HrEmployeeDeduction> HrEmployeeDeductions { get; set; } = new List<HrEmployeeDeduction>();

    public virtual ICollection<HrEmployeeDocument> HrEmployeeDocuments { get; set; } = new List<HrEmployeeDocument>();

    public virtual ICollection<HrEmployeeEducation> HrEmployeeEducations { get; set; } = new List<HrEmployeeEducation>();

    public virtual ICollection<HrEmployeeHistory> HrEmployeeHistories { get; set; } = new List<HrEmployeeHistory>();

    public virtual ICollection<HrEmployeeJobHistory> HrEmployeeJobHistories { get; set; } = new List<HrEmployeeJobHistory>();

    public virtual ICollection<HrEmployeeQualification> HrEmployeeQualifications { get; set; } = new List<HrEmployeeQualification>();

    public virtual ICollection<HrEmployeeRequest> HrEmployeeRequests { get; set; } = new List<HrEmployeeRequest>();

    public virtual ICollection<HrEmployeeSchedule> HrEmployeeSchedules { get; set; } = new List<HrEmployeeSchedule>();

    public virtual ICollection<HrJobApplicant> HrJobApplicants { get; set; } = new List<HrJobApplicant>();

    public virtual ICollection<HrPaySlip> HrPaySlips { get; set; } = new List<HrPaySlip>();
}
