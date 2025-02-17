using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HR_ManagementSystem.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<HrActivityChange> HrActivityChanges { get; set; }

    public virtual DbSet<HrAllowance> HrAllowances { get; set; }

    public virtual DbSet<HrAnnouncement> HrAnnouncements { get; set; }

    public virtual DbSet<HrAttendance> HrAttendances { get; set; }

    public virtual DbSet<HrBranch> HrBranches { get; set; }

    public virtual DbSet<HrCompany> HrCompanies { get; set; }

    public virtual DbSet<HrDailyReportTitle> HrDailyReportTitles { get; set; }

    public virtual DbSet<HrDeduction> HrDeductions { get; set; }

    public virtual DbSet<HrDepartment> HrDepartments { get; set; }

    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    public virtual DbSet<HrEmployeeAllowance> HrEmployeeAllowances { get; set; }

    public virtual DbSet<HrEmployeeBacker> HrEmployeeBackers { get; set; }

    public virtual DbSet<HrEmployeeBank> HrEmployeeBanks { get; set; }

    public virtual DbSet<HrEmployeeDailyReport> HrEmployeeDailyReports { get; set; }

    public virtual DbSet<HrEmployeeDailyReportDetail> HrEmployeeDailyReportDetails { get; set; }

    public virtual DbSet<HrEmployeeDeduction> HrEmployeeDeductions { get; set; }

    public virtual DbSet<HrEmployeeDocument> HrEmployeeDocuments { get; set; }

    public virtual DbSet<HrEmployeeEducation> HrEmployeeEducations { get; set; }

    public virtual DbSet<HrEmployeeHistory> HrEmployeeHistories { get; set; }

    public virtual DbSet<HrEmployeeJobHistory> HrEmployeeJobHistories { get; set; }

    public virtual DbSet<HrEmployeePaymentVoucher> HrEmployeePaymentVouchers { get; set; }

    public virtual DbSet<HrEmployeeQualification> HrEmployeeQualifications { get; set; }

    public virtual DbSet<HrEmployeeRequest> HrEmployeeRequests { get; set; }

    public virtual DbSet<HrEmployeeSchedule> HrEmployeeSchedules { get; set; }

    public virtual DbSet<HrJobApplicant> HrJobApplicants { get; set; }

    public virtual DbSet<HrJobOpening> HrJobOpenings { get; set; }

    public virtual DbSet<HrLeaveGroup> HrLeaveGroups { get; set; }

    public virtual DbSet<HrLeaveType> HrLeaveTypes { get; set; }

    public virtual DbSet<HrLoanType> HrLoanTypes { get; set; }

    public virtual DbSet<HrNotificationToken> HrNotificationTokens { get; set; }

    public virtual DbSet<HrPaySlip> HrPaySlips { get; set; }

    public virtual DbSet<HrPermission> HrPermissions { get; set; }

    public virtual DbSet<HrPolicy> HrPolicies { get; set; }

    public virtual DbSet<HrPosition> HrPositions { get; set; }

    public virtual DbSet<HrRule> HrRules { get; set; }

    public virtual DbSet<HrState> HrStates { get; set; }

    public virtual DbSet<HrStreet> HrStreets { get; set; }

    public virtual DbSet<HrTownship> HrTownships { get; set; }

    public virtual DbSet<TokenClaim> TokenClaims { get; set; }

    public virtual DbSet<ViHrAllowance> ViHrAllowances { get; set; }

    public virtual DbSet<ViHrAnnouncement> ViHrAnnouncements { get; set; }

    public virtual DbSet<ViHrAttendance> ViHrAttendances { get; set; }

    public virtual DbSet<ViHrBranch> ViHrBranches { get; set; }

    public virtual DbSet<ViHrCompany> ViHrCompanies { get; set; }

    public virtual DbSet<ViHrDailyReportTitle> ViHrDailyReportTitles { get; set; }

    public virtual DbSet<ViHrDeduction> ViHrDeductions { get; set; }

    public virtual DbSet<ViHrDepartment> ViHrDepartments { get; set; }

    public virtual DbSet<ViHrEmployee> ViHrEmployees { get; set; }

    public virtual DbSet<ViHrEmployeeAllowance> ViHrEmployeeAllowances { get; set; }

    public virtual DbSet<ViHrEmployeeDailyReport> ViHrEmployeeDailyReports { get; set; }

    public virtual DbSet<ViHrEmployeeDeduction> ViHrEmployeeDeductions { get; set; }

    public virtual DbSet<ViHrEmployeeHistory> ViHrEmployeeHistories { get; set; }

    public virtual DbSet<ViHrEmployeeLeaveRequest> ViHrEmployeeLeaveRequests { get; set; }

    public virtual DbSet<ViHrEmployeeLoanRequest> ViHrEmployeeLoanRequests { get; set; }

    public virtual DbSet<ViHrEmployeeRequest> ViHrEmployeeRequests { get; set; }

    public virtual DbSet<ViHrEmployeeResignRequest> ViHrEmployeeResignRequests { get; set; }

    public virtual DbSet<ViHrEmployeeSchedule> ViHrEmployeeSchedules { get; set; }

    public virtual DbSet<ViHrJobOpening> ViHrJobOpenings { get; set; }

    public virtual DbSet<ViHrLeaveGroup> ViHrLeaveGroups { get; set; }

    public virtual DbSet<ViHrLeaveType> ViHrLeaveTypes { get; set; }

    public virtual DbSet<ViHrLoanType> ViHrLoanTypes { get; set; }

    public virtual DbSet<ViHrPaySlip> ViHrPaySlips { get; set; }

    public virtual DbSet<ViHrPosition> ViHrPositions { get; set; }

    public virtual DbSet<ViHrRule> ViHrRules { get; set; }

    public virtual DbSet<ViHrStreet> ViHrStreets { get; set; }

    public virtual DbSet<ViHrTownship> ViHrTownships { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=ES_HR;User ID=sa;Password=123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<HrActivityChange>(entity =>
        {
            entity.ToTable("HR_Activity_Changes");

            entity.Property(e => e.ChangesBy).HasMaxLength(256);
            entity.Property(e => e.ChangesOn).HasColumnType("datetime");
            entity.Property(e => e.ChangesState).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(256);
        });

        modelBuilder.Entity<HrAllowance>(entity =>
        {
            entity.HasKey(e => e.AllowanceId).HasName("PK_Allowance");

            entity.ToTable("HR_Allowance");

            entity.Property(e => e.AllowanceName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrAnnouncement>(entity =>
        {
            entity.ToTable("HR_Announcement");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.Img).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendId).HasName("PK_HR_Attendace");

            entity.ToTable("HR_Attendance");

            entity.Property(e => e.AttendLog).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.Othour).HasColumnName("OTHour");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrAttendances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Attendance_HR_Employee");
        });

        modelBuilder.Entity<HrBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK_Branch_1");

            entity.ToTable("HR_Branch");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.ContactPerson).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.Photo).HasMaxLength(256);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(256);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrBranches)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Branch_HR_Company");
        });

        modelBuilder.Entity<HrCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK_Company");

            entity.ToTable("HR_Company");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.ContactPerson).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.LicenseNo).HasMaxLength(256);
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.Photo).HasMaxLength(256);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(256);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDailyReportTitle>(entity =>
        {
            entity.HasKey(e => e.ReportTitleId).HasName("PK_VI_HR_DailyReportTitle");

            entity.ToTable("HR_DailyReportTitle");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDeduction>(entity =>
        {
            entity.HasKey(e => e.DeductionId).HasName("PK_Deduction");

            entity.ToTable("HR_Deduction");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionName).HasMaxLength(256);
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDepartment>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK_Department_1");

            entity.ToTable("HR_Department");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.HrDepartments)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Department_HR_Branch");

            entity.HasOne(d => d.LeaveGroup).WithMany(p => p.HrDepartments)
                .HasForeignKey(d => d.LeaveGroupId)
                .HasConstraintName("FK_HR_Department_HR_LeaveGroup");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("HR_Employee");

            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DrivingLicense).HasMaxLength(256);
            entity.Property(e => e.Education).HasMaxLength(256);
            entity.Property(e => e.FingerPrint).HasMaxLength(256);
            entity.Property(e => e.FingerPrintNo).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.Nrc)
                .HasMaxLength(50)
                .HasColumnName("NRC");
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.Profile).HasMaxLength(256);
            entity.Property(e => e.Qualification).HasMaxLength(256);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrEmployeeAllowance>(entity =>
        {
            entity.HasKey(e => e.EmpAllowanceId);

            entity.ToTable("HR_Employee_Allowance");

            entity.Property(e => e.EmpAllowanceId).HasColumnName("Emp_AllowanceId");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EfficetiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Efficetive_Date");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.PaySlipId).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeAllowances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Allowance_HR_Employee");

            entity.HasOne(d => d.PaySlip).WithMany(p => p.HrEmployeeAllowances)
                .HasForeignKey(d => d.PaySlipId)
                .HasConstraintName("FK_HR_Employee_Allowance_HR_PaySlip");
        });

        modelBuilder.Entity<HrEmployeeBacker>(entity =>
        {
            entity.HasKey(e => new { e.BackerId, e.EmployeeId });

            entity.ToTable("HR_Employee_Backer");

            entity.Property(e => e.BackerId).ValueGeneratedOnAdd();
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.Nrc)
                .HasMaxLength(256)
                .HasColumnName("NRC");
            entity.Property(e => e.Occupation).HasMaxLength(256);
            entity.Property(e => e.Phone).HasMaxLength(256);
            entity.Property(e => e.Relative).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeBackers)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Backer_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeBank>(entity =>
        {
            entity.HasKey(e => new { e.BankAccNo, e.EmployeeId });

            entity.ToTable("HR_Employee_Bank");

            entity.Property(e => e.BankAccNo).HasMaxLength(128);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.BankName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrEmployeeDailyReport>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("HR_Employee_Daily_Report");

            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.ReportDate).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeDailyReports)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_HR_Employee_Daily_Report_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeDailyReportDetail>(entity =>
        {
            entity.HasKey(e => new { e.ReportId, e.TitleId });

            entity.ToTable("HR_Employee_Daily_Report_Detail");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Report).WithMany(p => p.HrEmployeeDailyReportDetails)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Daily_Report_Detail_HR_Employee_Daily_Report");

            entity.HasOne(d => d.Title).WithMany(p => p.HrEmployeeDailyReportDetails)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Daily_Report_Detail_HR_DailyReportTitle");
        });

        modelBuilder.Entity<HrEmployeeDeduction>(entity =>
        {
            entity.HasKey(e => e.EmpDeductionId);

            entity.ToTable("HR_Employee_Deduction");

            entity.Property(e => e.EmpDeductionId).HasColumnName("Emp_DeductionId");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EfficetiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Efficetive_Date");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.PaySlipId).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Deduction).WithMany(p => p.HrEmployeeDeductions)
                .HasForeignKey(d => d.DeductionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Deduction_HR_Deduction");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeDeductions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Deduction_HR_Employee");

            entity.HasOne(d => d.PaySlip).WithMany(p => p.HrEmployeeDeductions)
                .HasForeignKey(d => d.PaySlipId)
                .HasConstraintName("FK_HR_Employee_Deduction_HR_PaySlip");
        });

        modelBuilder.Entity<HrEmployeeDocument>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("HR_Employee_Document");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeDocuments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Document_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeEducation>(entity =>
        {
            entity.HasKey(e => e.EducationHistoryId).HasName("PK__HR_Emplo__576CCAED231ABC5E");

            entity.ToTable("HR_Employee_Education");

            entity.Property(e => e.EducationHistoryId).HasColumnName("EducationHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Degree).HasMaxLength(256);
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.Gpa)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GPA");
            entity.Property(e => e.InstitutionName).HasMaxLength(256);
            entity.Property(e => e.Major).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeEducations)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Education_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_HR_Employe_History");

            entity.ToTable("HR_Employee_History");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_Date");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.NewBranchId).HasColumnName("New_BranchId");
            entity.Property(e => e.NewDeptId).HasColumnName("New_DeptId");
            entity.Property(e => e.NewSalary).HasColumnName("New_Salary");
            entity.Property(e => e.PreviousBranchId).HasColumnName("Previous_BranchId");
            entity.Property(e => e.PreviousDeptId).HasColumnName("Previous_DeptId");
            entity.Property(e => e.PreviousSalary).HasColumnName("Previous_Salary");
            entity.Property(e => e.PromotionPositionId).HasColumnName("Promotion_PositionId");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeHistories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_History_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeJobHistory>(entity =>
        {
            entity.HasKey(e => e.JobHistoryId).HasName("PK__HR_Emplo__A809D914580F39F3");

            entity.ToTable("HR_Employee_JobHistory");

            entity.Property(e => e.JobHistoryId).HasColumnName("JobHistoryID");
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.JobDescription).HasColumnType("text");
            entity.Property(e => e.JobTitle).HasMaxLength(256);
            entity.Property(e => e.Location).HasMaxLength(256);
            entity.Property(e => e.SupervisorContact).HasMaxLength(256);
            entity.Property(e => e.SupervisorName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeJobHistories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_JobHistory_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeePaymentVoucher>(entity =>
        {
            entity.HasKey(e => e.VoucherNo);

            entity.ToTable("HR_Employee_Payment_Voucher");

            entity.Property(e => e.VoucherNo).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VourcharDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrEmployeeQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__Employee__C95C128A0792E1BC");

            entity.ToTable("HR_Employee_Qualification");

            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FileAttach).HasMaxLength(256);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.InstitutionName).HasMaxLength(256);
            entity.Property(e => e.QualificationName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeQualifications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Employee_Qualification_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("HR_Employee_Request");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.File3).HasMaxLength(256);
            entity.Property(e => e.ReplyBy).HasMaxLength(256);
            entity.Property(e => e.ReplyDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeRequests)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_HR_Employee_Request_HR_Employee");
        });

        modelBuilder.Entity<HrEmployeeSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK_HR_Employe_Schedule");

            entity.ToTable("HR_Employee_Schedule");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.IsOtpaid).HasColumnName("IsOTPaid");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e._1BusinessDayEndHour).HasColumnName("1_BusinessDayEndHour");
            entity.Property(e => e._1BusinessDayStartHour).HasColumnName("1_BusinessDayStartHour");
            entity.Property(e => e._2BusinessDayEndHour).HasColumnName("2_BusinessDayEndHour");
            entity.Property(e => e._2BusinessDayStartHour).HasColumnName("2_BusinessDayStartHour");
            entity.Property(e => e._3BusinessDayEndHour).HasColumnName("3_BusinessDayEndHour");
            entity.Property(e => e._3BusinessDayStartHour).HasColumnName("3_BusinessDayStartHour");
            entity.Property(e => e._4BusinessDayEndHour).HasColumnName("4_BusinessDayEndHour");
            entity.Property(e => e._4BusinessDayStartHour).HasColumnName("4_BusinessDayStartHour");
            entity.Property(e => e._5BusinessDayEndHour).HasColumnName("5_BusinessDayEndHour");
            entity.Property(e => e._5BusinessDayStartHour).HasColumnName("5_BusinessDayStartHour");
            entity.Property(e => e._6BusinessDayEndHour).HasColumnName("6_BusinessDayEndHour");
            entity.Property(e => e._6BusinessDayStartHour).HasColumnName("6_BusinessDayStartHour");
            entity.Property(e => e._7BusinessDayEndHour).HasColumnName("7_BusinessDayEndHour");
            entity.Property(e => e._7BusinessDayStartHour).HasColumnName("7_BusinessDayStartHour");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrEmployeeSchedules)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_HR_Employee_Schedule_HR_Employee");
        });

        modelBuilder.Entity<HrJobApplicant>(entity =>
        {
            entity.HasKey(e => e.ApplyId).HasName("PK_HR_Job_Recruitment");

            entity.ToTable("HR_Job_Applicant");

            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.ApplyDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Docs).HasMaxLength(256);
            entity.Property(e => e.Education).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Qualification).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrJobApplicants)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_HR_Job_Applicant_HR_Employee");

            entity.HasOne(d => d.Job).WithMany(p => p.HrJobApplicants)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Job_Applicant_HR_Job_Opening");
        });

        modelBuilder.Entity<HrJobOpening>(entity =>
        {
            entity.ToTable("HR_Job_Opening");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrLeaveGroup>(entity =>
        {
            entity.HasKey(e => e.LeaveGroupId);

            entity.ToTable("HR_LeaveGroup");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LeaveGroupName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.HrLeaveGroups)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveGroup_HR_Branch");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLeaveGroups)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveGroup_HR_Company");
        });

        modelBuilder.Entity<HrLeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId);

            entity.ToTable("HR_LeaveType");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LeaveName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.LeaveGroup).WithMany(p => p.HrLeaveTypes)
                .HasForeignKey(d => d.LeaveGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_LeaveType_HR_LeaveGroup");
        });

        modelBuilder.Entity<HrLoanType>(entity =>
        {
            entity.HasKey(e => e.LoanTypeId);

            entity.ToTable("HR_LoanType");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LoanTypeName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.HrLoanTypes)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_HR_LoanType_HR_Company");
        });

        modelBuilder.Entity<HrNotificationToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Device });

            entity.ToTable("HR_Notification_Token");

            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.Device).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Token).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrPaySlip>(entity =>
        {
            entity.HasKey(e => e.PayslipId);

            entity.ToTable("HR_PaySlip");

            entity.Property(e => e.PayslipId).HasMaxLength(10);
            entity.Property(e => e.AllowanceAmt).HasColumnName("Allowance_Amt");
            entity.Property(e => e.BankAccountNo).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionAmt).HasColumnName("Deduction_Amt");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.NetAmt).HasColumnName("Net_Amt");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrPaySlips)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_HR_PaySlip_HR_Employee");
        });

        modelBuilder.Entity<HrPermission>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("HR_Permission");

            entity.Property(e => e.UserId).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrPolicy>(entity =>
        {
            entity.ToTable("HR_Policy");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK_Position");

            entity.ToTable("HR_Position");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Dept).WithMany(p => p.HrPositions)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Position_HR_Department");
        });

        modelBuilder.Entity<HrRule>(entity =>
        {
            entity.HasKey(e => new { e.RuleId, e.DeductionId, e.CalculationType });

            entity.ToTable("HR_Rule");

            entity.Property(e => e.RuleId).ValueGeneratedOnAdd();
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Deduction).WithMany(p => p.HrRules)
                .HasForeignKey(d => d.DeductionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HR_Rule_HR_Deduction");
        });

        modelBuilder.Entity<HrState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK_State");

            entity.ToTable("HR_State");

            entity.Property(e => e.StateId).ValueGeneratedNever();
            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StateNameMm)
                .HasMaxLength(200)
                .HasColumnName("StateName_MM");
        });

        modelBuilder.Entity<HrStreet>(entity =>
        {
            entity.HasKey(e => e.StreetId).HasName("PK_Street");

            entity.ToTable("HR_Street");

            entity.Property(e => e.StreetId).ValueGeneratedNever();
            entity.Property(e => e.StreetName).HasMaxLength(200);
            entity.Property(e => e.StreetNameMm)
                .HasMaxLength(200)
                .HasColumnName("StreetName_MM");
        });

        modelBuilder.Entity<HrTownship>(entity =>
        {
            entity.HasKey(e => e.TownshipId).HasName("PK_Township");

            entity.ToTable("HR_Township");

            entity.Property(e => e.TownshipId).ValueGeneratedNever();
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.TownshipNameMm)
                .HasMaxLength(200)
                .HasColumnName("TownshipName_MM");
        });

        modelBuilder.Entity<TokenClaim>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Device });

            entity.ToTable("Token_Claim");

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.Device).HasMaxLength(128);
            entity.Property(e => e.RefreshDate).HasColumnType("datetime");
            entity.Property(e => e.TokenExpiry).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrAllowance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Allowance");

            entity.Property(e => e.AllowanceName).HasMaxLength(256);
            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrAnnouncement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Announcement");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.EmployeeName).HasMaxLength(256);
            entity.Property(e => e.Img).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Attendance");

            entity.Property(e => e.AttendLog).HasColumnType("datetime");
            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.Othour).HasColumnName("OTHour");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Branch");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.ContactPerson).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.Photo).HasMaxLength(256);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(256);
            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Company");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.ContactPerson).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.LicenseNo).HasMaxLength(256);
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.Photo).HasMaxLength(256);
            entity.Property(e => e.PrimaryPhone).HasMaxLength(256);
            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrDailyReportTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_DailyReportTitle");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrDeduction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Deduction");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionName).HasMaxLength(256);
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Department");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.DrivingLicense).HasMaxLength(256);
            entity.Property(e => e.Education).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FingerPrint).HasMaxLength(256);
            entity.Property(e => e.FingerPrintNo).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.HouseNo).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.Nrc)
                .HasMaxLength(50)
                .HasColumnName("NRC");
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.Profile).HasMaxLength(256);
            entity.Property(e => e.Qualification).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);
            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StreetName).HasMaxLength(256);
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrEmployeeAllowance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Allowance");

            entity.Property(e => e.AllowanceName).HasMaxLength(256);
            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EfficetiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Efficetive_Date");
            entity.Property(e => e.EmpAllowanceId).HasColumnName("Emp_AllowanceId");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.PaySlipId).HasMaxLength(10);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.Profile).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrEmployeeDailyReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Daily_Report");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrEmployeeDeduction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Deduction");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionName).HasMaxLength(256);
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EfficetiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Efficetive_Date");
            entity.Property(e => e.EmpDeductionId).HasColumnName("Emp_DeductionId");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.OtherPhone).HasMaxLength(256);
            entity.Property(e => e.PaySlipId).HasMaxLength(10);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.Profile).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrEmployeeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_History");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_Date");
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.NewBranchId).HasColumnName("New_BranchId");
            entity.Property(e => e.NewBranchName)
                .HasMaxLength(256)
                .HasColumnName("New_BranchName");
            entity.Property(e => e.NewDeptId).HasColumnName("New_DeptId");
            entity.Property(e => e.NewDeptName)
                .HasMaxLength(256)
                .HasColumnName("New_DeptName");
            entity.Property(e => e.NewSalary).HasColumnName("New_Salary");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.PreviousBranchId).HasColumnName("Previous_BranchId");
            entity.Property(e => e.PreviousBranchName)
                .HasMaxLength(256)
                .HasColumnName("Previous_BranchName");
            entity.Property(e => e.PreviousDeptId).HasColumnName("Previous_DeptId");
            entity.Property(e => e.PreviousDeptName)
                .HasMaxLength(256)
                .HasColumnName("Previous_DeptName");
            entity.Property(e => e.PreviousSalary).HasColumnName("Previous_Salary");
            entity.Property(e => e.PromotionPositionId).HasColumnName("Promotion_PositionId");
            entity.Property(e => e.PromotionPositionName)
                .HasMaxLength(256)
                .HasColumnName("Promotion_PositionName");
        });

        modelBuilder.Entity<ViHrEmployeeLeaveRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Leave_Request");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.File3).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.RelatedTypeName).HasMaxLength(256);
            entity.Property(e => e.ReplyBy).HasMaxLength(256);
            entity.Property(e => e.ReplyDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrEmployeeLoanRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Loan_Request");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.File3).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.RelatedTypeName).HasMaxLength(256);
            entity.Property(e => e.ReplyBy).HasMaxLength(256);
            entity.Property(e => e.ReplyDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrEmployeeRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Request");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.File3).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.ReplyBy).HasMaxLength(256);
            entity.Property(e => e.ReplyDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ViHrEmployeeResignRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Resign_Request");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.File1).HasMaxLength(256);
            entity.Property(e => e.File2).HasMaxLength(256);
            entity.Property(e => e.File3).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.ReplyBy).HasMaxLength(256);
            entity.Property(e => e.ReplyDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrEmployeeSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Employee_Schedule");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.IsOtpaid).HasColumnName("IsOTPaid");
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e._1BusinessDayEndHour).HasColumnName("1_BusinessDayEndHour");
            entity.Property(e => e._1BusinessDayStartHour).HasColumnName("1_BusinessDayStartHour");
            entity.Property(e => e._2BusinessDayEndHour).HasColumnName("2_BusinessDayEndHour");
            entity.Property(e => e._2BusinessDayStartHour).HasColumnName("2_BusinessDayStartHour");
            entity.Property(e => e._3BusinessDayEndHour).HasColumnName("3_BusinessDayEndHour");
            entity.Property(e => e._3BusinessDayStartHour).HasColumnName("3_BusinessDayStartHour");
            entity.Property(e => e._4BusinessDayEndHour).HasColumnName("4_BusinessDayEndHour");
            entity.Property(e => e._4BusinessDayStartHour).HasColumnName("4_BusinessDayStartHour");
            entity.Property(e => e._5BusinessDayEndHour).HasColumnName("5_BusinessDayEndHour");
            entity.Property(e => e._5BusinessDayStartHour).HasColumnName("5_BusinessDayStartHour");
            entity.Property(e => e._6BusinessDayEndHour).HasColumnName("6_BusinessDayEndHour");
            entity.Property(e => e._6BusinessDayStartHour).HasColumnName("6_BusinessDayStartHour");
            entity.Property(e => e._7BusinessDayEndHour).HasColumnName("7_BusinessDayEndHour");
            entity.Property(e => e._7BusinessDayStartHour).HasColumnName("7_BusinessDayStartHour");
        });

        modelBuilder.Entity<ViHrJobOpening>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Job_Opening");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrLeaveGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_LeaveGroup");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LeaveGroupName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrLeaveType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_LeaveType");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LeaveName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrLoanType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Loan_Type");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.LoanTypeName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrPaySlip>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_PaySlip");

            entity.Property(e => e.AllowanceAmt).HasColumnName("Allowance_Amt");
            entity.Property(e => e.BankAccountNo).HasMaxLength(256);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionAmt).HasColumnName("Deduction_Amt");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(256);
            entity.Property(e => e.NetAmt).HasColumnName("Net_Amt");
            entity.Property(e => e.PayslipId).HasMaxLength(10);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Position");

            entity.Property(e => e.BranchName).HasMaxLength(256);
            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.PositionName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Rule");

            entity.Property(e => e.CompanyId).HasMaxLength(5);
            entity.Property(e => e.CompanyName).HasMaxLength(256);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeductionName).HasMaxLength(256);
            entity.Property(e => e.DeletedBy).HasMaxLength(256);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptName).HasMaxLength(256);
            entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViHrStreet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Street");

            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StateNameMm)
                .HasMaxLength(200)
                .HasColumnName("StateName_MM");
            entity.Property(e => e.StreetName).HasMaxLength(200);
            entity.Property(e => e.StreetNameMm)
                .HasMaxLength(200)
                .HasColumnName("StreetName_MM");
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.TownshipNameMm)
                .HasMaxLength(200)
                .HasColumnName("TownshipName_MM");
        });

        modelBuilder.Entity<ViHrTownship>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_HR_Township");

            entity.Property(e => e.StateName).HasMaxLength(200);
            entity.Property(e => e.StateNameMm)
                .HasMaxLength(200)
                .HasColumnName("StateName_MM");
            entity.Property(e => e.TownshipName).HasMaxLength(200);
            entity.Property(e => e.TownshipNameMm)
                .HasMaxLength(200)
                .HasColumnName("TownshipName_MM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
