using System;
using System.Collections.Generic;

namespace HR_ManagementSystem.Models;

public partial class HrEmployeeQualification
{
    public long QualificationId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string QualificationName { get; set; } = null!;

    public string? InstitutionName { get; set; }

    public DateOnly? DateObtained { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string? Grade { get; set; }

    public string? Description { get; set; }

    public string? FileAttach { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? DeletedBy { get; set; }

    public string? Remark { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;
}
