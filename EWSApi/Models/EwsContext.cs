using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EWSApi.Models;

public partial class EwsContext : DbContext
{
    public EwsContext()
    {
    }

    public EwsContext(DbContextOptions<EwsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<CaseClassificationType> CaseClassificationType { get; set; }

    public virtual DbSet<CitizenRegister> CitizenRegister { get; set; }

    public virtual DbSet<CitizenRegisterVaccine> CitizenRegisterVaccine { get; set; }

    public virtual DbSet<City> City { get; set; }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<DiseaseInfection> DiseaseInfection { get; set; }

    public virtual DbSet<DiseaseInfectionType> DiseaseInfectionType { get; set; }

    public virtual DbSet<DocumentType> DocumentType { get; set; }

    public virtual DbSet<Ethnicity> Ethnicity { get; set; }

    public virtual DbSet<Examination> Examination { get; set; }

    public virtual DbSet<Faqcategory> Faqcategory { get; set; }

    public virtual DbSet<FaqcategoryGroup> FaqcategoryGroup { get; set; }

    public virtual DbSet<Faqquestion> Faqquestion { get; set; }

    public virtual DbSet<FaqquestionStatus> FaqquestionStatus { get; set; }

    public virtual DbSet<Faqrate> Faqrate { get; set; }

    public virtual DbSet<Faqvideo> Faqvideo { get; set; }

    public virtual DbSet<Gender> Gender { get; set; }

    public virtual DbSet<HealthInstitution> HealthInstitution { get; set; }

    public virtual DbSet<HealthInstitutionLevel> HealthInstitutionLevel { get; set; }

    public virtual DbSet<Log> Log { get; set; }

    public virtual DbSet<MedicalStaff> MedicalStaff { get; set; }

    public virtual DbSet<Menu> Menu { get; set; }

    public virtual DbSet<Nationality> Nationality { get; set; }

    public virtual DbSet<Notification> Notification { get; set; }

    public virtual DbSet<ProfessionType> ProfessionType { get; set; }

    public virtual DbSet<ReportRegister> ReportRegister { get; set; }

    public virtual DbSet<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; }

    public virtual DbSet<ReportRegisterContact> ReportRegisterContact { get; set; }

    public virtual DbSet<ReportRegisterContactSurvey> ReportRegisterContactSurvey { get; set; }

    public virtual DbSet<ReportRegisterReference> ReportRegisterReference { get; set; }

    public virtual DbSet<ReportRegisterSampleTaken> ReportRegisterSampleTaken { get; set; }

    public virtual DbSet<ReportRegisterStatus> ReportRegisterStatus { get; set; }

    public virtual DbSet<ReportRegisterStatusDetail> ReportRegisterStatusDetail { get; set; }

    public virtual DbSet<ReportRegisterStatusType> ReportRegisterStatusType { get; set; }

    public virtual DbSet<ReportRegisterSurvey> ReportRegisterSurvey { get; set; }

    public virtual DbSet<ReportRegisterTest> ReportRegisterTest { get; set; }

    public virtual DbSet<ReportRegisterTestResult> ReportRegisterTestResult { get; set; }

    public virtual DbSet<ReportingTimeType> ReportingTimeType { get; set; }

    public virtual DbSet<SampleTakenType> SampleTakenType { get; set; }

    public virtual DbSet<SearchIndicators> SearchIndicators { get; set; }

    public virtual DbSet<SearchKeyWord> SearchKeyWord { get; set; }

    public virtual DbSet<SearchResults> SearchResults { get; set; }

    public virtual DbSet<SearchSourceSite> SearchSourceSite { get; set; }

    public virtual DbSet<Settlement> Settlement { get; set; }

    public virtual DbSet<StatusType> StatusType { get; set; }

    public virtual DbSet<SubMenu> SubMenu { get; set; }

    public virtual DbSet<SurveyType> SurveyType { get; set; }

    public virtual DbSet<SurveyTypeTemp> SurveyTypeTemp { get; set; }

    public virtual DbSet<SyndromeType> SyndromeType { get; set; }

    public virtual DbSet<TestType> TestType { get; set; }

    public virtual DbSet<UserAudit> UserAudit { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=dev;Database=EWS;user id=ateam_sql; password=Ateam.sql2019#; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRoleClaims>(entity =>
        {
            entity.Property(e => e.RoleId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoles>(entity =>
        {
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Name_SR");
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaims>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogins>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserTokens>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUsers>(entity =>
        {
            entity.Property(e => e.AllowAdminNotification)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.AllowNotifications)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Birthdate).HasColumnType("datetime");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Firstname).HasDefaultValueSql("(N'')");
            entity.Property(e => e.GoogleToken).HasDefaultValueSql("(N'')");
            entity.Property(e => e.ImageProfile).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.InsertedFrom).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Lastname).HasDefaultValueSql("(N'')");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.PasswordExpires).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.PersonalNumber).HasMaxLength(128);
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRoles",
                    r => r.HasOne<AspNetRoles>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUsers>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                    });
        });

        modelBuilder.Entity<CaseClassificationType>(entity =>
        {
            entity.HasKey(e => e.CaseClassificationTypeId).HasName("PK_CaseClassificationTypeID");

            entity.Property(e => e.CaseClassificationTypeId).HasColumnName("CaseClassificationTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<CitizenRegister>(entity =>
        {
            entity.Property(e => e.CitizenRegisterId).HasColumnName("CitizenRegisterID");
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.BirthPlace).HasMaxLength(128);
            entity.Property(e => e.Birthdate).HasColumnType("date");
            entity.Property(e => e.CountryId)
                .HasDefaultValueSql("((1))")
                .HasComment("The default value is 1 - Kosova")
                .HasColumnName("CountryID");
            entity.Property(e => e.Email).HasMaxLength(128);
            entity.Property(e => e.FatherName).HasMaxLength(128);
            entity.Property(e => e.Firstname).HasMaxLength(64);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Lastname).HasMaxLength(64);
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MotherName).HasMaxLength(128);
            entity.Property(e => e.Municipality).HasMaxLength(256);
            entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");
            entity.Property(e => e.PartnerName).HasMaxLength(128);
            entity.Property(e => e.PersonalNumber).HasMaxLength(32);
            entity.Property(e => e.PhoneNumber).HasMaxLength(64);
            entity.Property(e => e.Settlement).HasMaxLength(256);
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<CitizenRegisterVaccine>(entity =>
        {
            entity.Property(e => e.CitizenRegisterVaccineId).HasColumnName("CitizenRegisterVaccineID");
            entity.Property(e => e.CitizenRegisterId).HasColumnName("CitizenRegisterID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.VaccineCode)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.VaccineDate).HasColumnType("datetime");
            entity.Property(e => e.VaccineType).HasMaxLength(256);

            entity.HasOne(d => d.CitizenRegister).WithMany(p => p.CitizenRegisterVaccine)
                .HasForeignKey(d => d.CitizenRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitizenRegisterVaccine_CitizenRegister");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City", "Core");

            entity.Property(e => e.CityId)
                .ValueGeneratedNever()
                .HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Country).WithMany(p => p.City)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_City_Country");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country", "Core");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("CountryID");
            entity.Property(e => e.Code).HasMaxLength(8);
            entity.Property(e => e.FlagPath)
                .HasMaxLength(256)
                .HasColumnName("Flag_path");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.Prefix).HasMaxLength(5);
        });

        modelBuilder.Entity<DiseaseInfection>(entity =>
        {
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.DiseaseCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.DiseaseInfectionTypeId).HasColumnName("DiseaseInfectionTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.ReportingTimeTypeId).HasColumnName("ReportingTimeTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.DiseaseInfectionType).WithMany(p => p.DiseaseInfection)
                .HasForeignKey(d => d.DiseaseInfectionTypeId)
                .HasConstraintName("FK_DiseaseInfection_DiseaseInfectionType");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.DiseaseInfectionInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfection_AspNetUsers");

            entity.HasOne(d => d.ReportingTimeType).WithMany(p => p.DiseaseInfection)
                .HasForeignKey(d => d.ReportingTimeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfection_ReportingTimeType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.DiseaseInfectionUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DiseaseInfection_AspNetUsers1");
        });

        modelBuilder.Entity<DiseaseInfectionType>(entity =>
        {
            entity.Property(e => e.DiseaseInfectionTypeId).HasColumnName("DiseaseInfectionTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.DiseaseInfectionTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfectionType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.DiseaseInfectionTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DiseaseInfectionType_AspNetUsers1");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
        });

        modelBuilder.Entity<Ethnicity>(entity =>
        {
            entity.ToTable("Ethnicity", "Core");

            entity.Property(e => e.EthnicityId).HasColumnName("EthnicityID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
        });

        modelBuilder.Entity<Examination>(entity =>
        {
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.ExaminationCode).HasMaxLength(50);
            entity.Property(e => e.ExaminationName).HasMaxLength(100);
        });

        modelBuilder.Entity<Faqcategory>(entity =>
        {
            entity.ToTable("FAQCategory", "Core");

            entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryID");
            entity.Property(e => e.Color).HasMaxLength(64);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(128)
                .HasColumnName("Description_EN");
            entity.Property(e => e.DescriptionSq)
                .HasMaxLength(128)
                .HasColumnName("Description_SQ");
            entity.Property(e => e.DescriptionSr)
                .HasMaxLength(128)
                .HasColumnName("Description_SR");
            entity.Property(e => e.Icon).HasMaxLength(64);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.Faqcategory)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQCategory_AspNetUsers");
        });

        modelBuilder.Entity<FaqcategoryGroup>(entity =>
        {
            entity.ToTable("FAQCategoryGroup", "Core");

            entity.Property(e => e.FaqcategoryGroupId).HasColumnName("FAQCategoryGroupID");
            entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.RoleId)
                .HasMaxLength(450)
                .HasColumnName("RoleID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.Faqcategory).WithMany(p => p.FaqcategoryGroup)
                .HasForeignKey(d => d.FaqcategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQCategoryGroup_FAQCategory");

            entity.HasOne(d => d.Role).WithMany(p => p.FaqcategoryGroup)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQCategoryGroup_FAQCategoryGroup1");
        });

        modelBuilder.Entity<Faqquestion>(entity =>
        {
            entity.ToTable("FAQQuestion", "Core");

            entity.Property(e => e.FaqquestionId).HasColumnName("FAQQuestionID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Question).HasMaxLength(256);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
            entity.Property(e => e.UserName).HasMaxLength(60);
            entity.Property(e => e.UserSurname).HasMaxLength(60);

            entity.HasOne(d => d.Faqcategory).WithMany(p => p.Faqquestion)
                .HasForeignKey(d => d.FaqcategoryId)
                .HasConstraintName("FK_FAQQuestion_FAQCategory");
        });

        modelBuilder.Entity<FaqquestionStatus>(entity =>
        {
            entity.ToTable("FAQQuestionStatus", "Core");

            entity.Property(e => e.FaqquestionStatusId).HasColumnName("FAQQuestionStatusID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.FaqquestionId).HasColumnName("FAQQuestionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.StatusTypeId).HasColumnName("StatusTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.Faqquestion).WithMany(p => p.FaqquestionStatus)
                .HasForeignKey(d => d.FaqquestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQQuestionStatus_FAQQuestion");

            entity.HasOne(d => d.StatusType).WithMany(p => p.FaqquestionStatus)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQQuestionStatus_StatusType");
        });

        modelBuilder.Entity<Faqrate>(entity =>
        {
            entity.ToTable("FAQRate", "Core");

            entity.Property(e => e.FaqrateId).HasColumnName("FAQRateID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.FaqquestionId).HasColumnName("FAQQuestionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.Faqquestion).WithMany(p => p.Faqrate)
                .HasForeignKey(d => d.FaqquestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQRate_FAQQuestion");
        });

        modelBuilder.Entity<Faqvideo>(entity =>
        {
            entity.ToTable("FAQVideo", "Core");

            entity.Property(e => e.FaqvideoId).HasColumnName("FAQVideoID");
            entity.Property(e => e.Description).HasMaxLength(2048);
            entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Path).HasMaxLength(2048);
            entity.Property(e => e.Title).HasMaxLength(512);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.Faqcategory).WithMany(p => p.Faqvideo)
                .HasForeignKey(d => d.FaqcategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAQVideo_FAQCategory");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender", "Core");

            entity.Property(e => e.GenderId)
                .ValueGeneratedNever()
                .HasColumnName("GenderID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
        });

        modelBuilder.Entity<HealthInstitution>(entity =>
        {
            entity.HasKey(e => e.HealthInstitutionId).HasName("PK_HealthRegister");

            entity.Property(e => e.HealthInstitutionId).HasColumnName("HealthInstitutionID");
            entity.Property(e => e.Address).HasMaxLength(128);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.HealthInstitutionLevelId).HasColumnName("HealthInstitutionLevelID");
            entity.Property(e => e.IdentificationNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.LicenceNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MinicipalityId).HasColumnName("MinicipalityID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(256)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(256)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(256)
                .HasColumnName("Name_SR");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.ShortNameEn)
                .HasMaxLength(32)
                .HasColumnName("ShortName_EN");
            entity.Property(e => e.ShortNameSq)
                .HasMaxLength(32)
                .HasColumnName("ShortName_SQ");
            entity.Property(e => e.ShortNameSr)
                .HasMaxLength(32)
                .HasColumnName("ShortName_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.HealthInstitutionLevel).WithMany(p => p.HealthInstitution)
                .HasForeignKey(d => d.HealthInstitutionLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthInstitution_HealthInstitutionLevel");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.HealthInstitutionInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthRegister_AspNetUsers");

            entity.HasOne(d => d.Minicipality).WithMany(p => p.HealthInstitution)
                .HasForeignKey(d => d.MinicipalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthRegister_City");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.HealthInstitutionUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_HealthInstitution_AspNetUsers");

            entity.HasOne(d => d.Settlement).WithMany(p => p.HealthInstitution)
                .HasForeignKey(d => new { d.SettlementId, d.MinicipalityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthRegister_Settlement");
        });

        modelBuilder.Entity<HealthInstitutionLevel>(entity =>
        {
            entity.HasKey(e => e.HealthInstitutionLevelId).HasName("PK_HealthLevel");

            entity.Property(e => e.HealthInstitutionLevelId).HasColumnName("HealthInstitutionLevelID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.HealthInstitutionLevelInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthLevel_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.HealthInstitutionLevelUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_HealthLevel_AspNetUsers1");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("Log", "Core");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Action).HasMaxLength(128);
            entity.Property(e => e.BError).HasColumnName("bError");
            entity.Property(e => e.Controller).HasMaxLength(128);
            entity.Property(e => e.DescriptionTitle).HasMaxLength(256);
            entity.Property(e => e.Developer).HasMaxLength(128);
            entity.Property(e => e.HostName).HasMaxLength(128);
            entity.Property(e => e.HttpMethod).HasMaxLength(64);
            entity.Property(e => e.Ip)
                .HasMaxLength(64)
                .HasColumnName("IP");
            entity.Property(e => e.Url).HasMaxLength(2048);
            entity.Property(e => e.UserId)
                .HasMaxLength(450)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Log)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Log_Log");
        });

        modelBuilder.Entity<MedicalStaff>(entity =>
        {
            entity.Property(e => e.MedicalStaffId).HasColumnName("MedicalStaffID");
            entity.Property(e => e.Firstname).HasMaxLength(64);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Lastname).HasMaxLength(64);
            entity.Property(e => e.LicenceNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Specialization).HasMaxLength(256);
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu", "Core");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.Action).HasMaxLength(128);
            entity.Property(e => e.Area).HasMaxLength(128);
            entity.Property(e => e.Claim).HasMaxLength(128);
            entity.Property(e => e.ClaimType).HasMaxLength(128);
            entity.Property(e => e.Controller).HasMaxLength(128);
            entity.Property(e => e.Icon).HasMaxLength(128);
            entity.Property(e => e.InsertedFrom).HasMaxLength(256);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.Roles).HasMaxLength(1024);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(256);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality", "Core");

            entity.Property(e => e.NationalityId)
                .ValueGeneratedNever()
                .HasColumnName("NationalityID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification", "Core");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.Details).HasMaxLength(1024);
            entity.Property(e => e.Icon).HasMaxLength(128);
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Receiver).HasMaxLength(450);
            entity.Property(e => e.Title).HasMaxLength(512);
            entity.Property(e => e.Url).HasMaxLength(1024);
        });

        modelBuilder.Entity<ProfessionType>(entity =>
        {
            entity.Property(e => e.ProfessionTypeId).HasColumnName("ProfessionTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ProfessionTypeEn)
                .HasMaxLength(128)
                .HasColumnName("ProfessionType_EN");
            entity.Property(e => e.ProfessionTypeSq)
                .HasMaxLength(128)
                .HasColumnName("ProfessionType_SQ");
            entity.Property(e => e.ProfessionTypeSr)
                .HasMaxLength(128)
                .HasColumnName("ProfessionType_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<ReportRegister>(entity =>
        {
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.Birthdate).HasColumnType("date");
            entity.Property(e => e.CitizenRegisterId).HasColumnName("CitizenRegisterID");
            entity.Property(e => e.ConsultingDate).HasColumnType("datetime");
            entity.Property(e => e.FatherName).HasMaxLength(128);
            entity.Property(e => e.Firstname).HasMaxLength(64);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HealthInstitutionAddress).HasMaxLength(256);
            entity.Property(e => e.HealthInstitutionId).HasColumnName("HealthInstitutionID");
            entity.Property(e => e.HealthInstitutionName).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Lastname).HasMaxLength(64);
            entity.Property(e => e.MotherName).HasMaxLength(128);
            entity.Property(e => e.PartnerName).HasMaxLength(128);
            entity.Property(e => e.PersonalNumber).HasMaxLength(32);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ProfessionTypeId).HasColumnName("ProfessionTypeID");
            entity.Property(e => e.SampleTakenDate).HasColumnType("datetime");
            entity.Property(e => e.SymptomDate).HasColumnType("datetime");
            entity.Property(e => e.SyndromeTypeId).HasColumnName("SyndromeTypeID");
            entity.Property(e => e.UniqueNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.CitizenRegister).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.CitizenRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegister_CitizenRegister");

            entity.HasOne(d => d.HealthInstitution).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.HealthInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegister_HealthInstitution");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegister_AspNetUsers");

            entity.HasOne(d => d.ProfessionType).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.ProfessionTypeId)
                .HasConstraintName("FK_ReportRegister_ProfessionType");

            entity.HasOne(d => d.SyndromeType).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.SyndromeTypeId)
                .HasConstraintName("FK_ReportRegister_SyndromeType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegister_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterCaseClassification>(entity =>
        {
            entity.HasKey(e => e.ReportRegisterCaseClassificationId).HasName("PK_CaseClassification");

            entity.Property(e => e.ReportRegisterCaseClassificationId).HasColumnName("ReportRegisterCaseClassificationID");
            entity.Property(e => e.CaseClassificationTypeId).HasColumnName("CaseClassificationTypeID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.DiseaseInfectionId)
                .HasComment("Diagnose")
                .HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.SyndromeTypeId).HasColumnName("SyndromeTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.CaseClassificationType).WithMany(p => p.ReportRegisterCaseClassification)
                .HasForeignKey(d => d.CaseClassificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterCaseClassification_CaseClassificationType");

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.ReportRegisterCaseClassification)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterCaseClassification_DiseaseInfection");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterCaseClassificationInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterCaseClassification_AspNetUsers");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterCaseClassification)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterCaseClassification_ReportRegister");

            entity.HasOne(d => d.SyndromeType).WithMany(p => p.ReportRegisterCaseClassification)
                .HasForeignKey(d => d.SyndromeTypeId)
                .HasConstraintName("FK_ReportRegisterCaseClassification_SyndromeType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterCaseClassificationUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterCaseClassification_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterContact>(entity =>
        {
            entity.Property(e => e.ReportRegisterContactId).HasColumnName("ReportRegisterContactID");
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.FirstName).HasMaxLength(64);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.LastName).HasMaxLength(64);
            entity.Property(e => e.PersonalNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");
            entity.Property(e => e.Relationship).HasMaxLength(64);
            entity.Property(e => e.ReportRegisterContactPersonId).HasColumnName("ReportRegisterContactPersonID");
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterContactInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterContact_AspNetUsers");

            entity.HasOne(d => d.Profession).WithMany(p => p.ReportRegisterContact)
                .HasForeignKey(d => d.ProfessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterContact_ProfessionType");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterContact)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterContact_ReportRegister");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterContactUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterContact_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterContactSurvey>(entity =>
        {
            entity.Property(e => e.ReportRegisterContactSurveyId).HasColumnName("ReportRegisterContactSurveyID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterContactId).HasColumnName("ReportRegisterContactID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterContactSurveyInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterContactSurvey_AspNetUsers");

            entity.HasOne(d => d.ReportRegisterContact).WithMany(p => p.ReportRegisterContactSurvey)
                .HasForeignKey(d => d.ReportRegisterContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterContactSurvey_ReportRegisterContact");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterContactSurveyUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterContactSurvey_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterReference>(entity =>
        {
            entity.Property(e => e.ReportRegisterReferenceId).HasColumnName("ReportRegisterReferenceID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.HealthInstitutionFromAddress).HasMaxLength(128);
            entity.Property(e => e.HealthInstitutionFromId).HasColumnName("HealthInstitutionFromID");
            entity.Property(e => e.HealthInstitutionFromName).HasMaxLength(256);
            entity.Property(e => e.HealthInstitutionToAddress).HasMaxLength(128);
            entity.Property(e => e.HealthInstitutionToId).HasColumnName("HealthInstitutionToID");
            entity.Property(e => e.HealthInstitutionToName).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterStatusId).HasColumnName("ReportRegisterStatusID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.HealthInstitutionFrom).WithMany(p => p.ReportRegisterReferenceHealthInstitutionFrom)
                .HasForeignKey(d => d.HealthInstitutionFromId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterReference_HealthInstitution");

            entity.HasOne(d => d.HealthInstitutionTo).WithMany(p => p.ReportRegisterReferenceHealthInstitutionTo)
                .HasForeignKey(d => d.HealthInstitutionToId)
                .HasConstraintName("FK_ReportRegisterReference_HealthInstitution1");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterReferenceInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterReference_AspNetUsers");

            entity.HasOne(d => d.ReportRegisterStatus).WithMany(p => p.ReportRegisterReference)
                .HasForeignKey(d => d.ReportRegisterStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterReference_ReportRegisterStatus");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterReferenceUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterReference_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterSampleTaken>(entity =>
        {
            entity.Property(e => e.ReportRegisterSampleTakenId).HasColumnName("ReportRegisterSampleTakenID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.SampleTakenTypeId).HasColumnName("SampleTakenTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterSampleTakenInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterSampleTaken_AspNetUsers");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterSampleTaken)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterSampleTaken_ReportRegister");

            entity.HasOne(d => d.SampleTakenType).WithMany(p => p.ReportRegisterSampleTaken)
                .HasForeignKey(d => d.SampleTakenTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterSampleTaken_SampleTakenType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterSampleTakenUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterSampleTaken_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterStatus>(entity =>
        {
            entity.Property(e => e.ReportRegisterStatusId).HasColumnName("ReportRegisterStatusID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.MedicalStaffId).HasColumnName("MedicalStaffID");
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.ReportRegisterStatusTypeId).HasColumnName("ReportRegisterStatusTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterStatusInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatus_AspNetUsers");

            entity.HasOne(d => d.MedicalStaff).WithMany(p => p.ReportRegisterStatus)
                .HasForeignKey(d => d.MedicalStaffId)
                .HasConstraintName("FK_ReportRegisterStatus_MedicalStaff");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterStatus)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatus_ReportRegister");

            entity.HasOne(d => d.ReportRegisterStatusType).WithMany(p => p.ReportRegisterStatus)
                .HasForeignKey(d => d.ReportRegisterStatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatus_ReportRegisterStatusType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterStatusUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterStatus_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterStatusDetail>(entity =>
        {
            entity.Property(e => e.ReportRegisterStatusDetailId).HasColumnName("ReportRegisterStatusDetailID");
            entity.Property(e => e.BedNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.Floor)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterStatusId).HasColumnName("ReportRegisterStatusID");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Therapy).HasMaxLength(256);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterStatusDetailInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatusDetail_AspNetUsers");

            entity.HasOne(d => d.ReportRegisterStatus).WithMany(p => p.ReportRegisterStatusDetail)
                .HasForeignKey(d => d.ReportRegisterStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatusDetail_ReportRegisterStatus");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterStatusDetailUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterStatusDetail_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterStatusType>(entity =>
        {
            entity.Property(e => e.ReportRegisterStatusTypeId).HasColumnName("ReportRegisterStatusTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterStatusType)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterStatusType_AspNetUsers");
        });

        modelBuilder.Entity<ReportRegisterSurvey>(entity =>
        {
            entity.Property(e => e.ReportRegisterSurveyId).HasColumnName("ReportRegisterSurveyID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterSurveyInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterSurvey_AspNetUsers");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterSurvey)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterSurvey_ReportRegister");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterSurveyUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterSurvey_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterTest>(entity =>
        {
            entity.Property(e => e.ReportRegisterTestId).HasColumnName("ReportRegisterTestID");
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.TestTypeName).HasMaxLength(128);

            entity.HasOne(d => d.Examination).WithMany(p => p.ReportRegisterTest)
                .HasForeignKey(d => d.ExaminationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTest_Examination");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterTest)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTest_ReportRegister");
        });

        modelBuilder.Entity<ReportRegisterTestResult>(entity =>
        {
            entity.Property(e => e.ReportRegisterTestResultId).HasColumnName("ReportRegisterTestResultID");
            entity.Property(e => e.HealthInstitutionAddress).HasMaxLength(128);
            entity.Property(e => e.HealthInstitutionId).HasColumnName("HealthInstitutionID");
            entity.Property(e => e.HealthInstitutionName).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.ReportRegisterTestId).HasColumnName("ReportRegisterTestID");
            entity.Property(e => e.ResultDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(128);

            entity.HasOne(d => d.HealthInstitution).WithMany(p => p.ReportRegisterTestResult)
                .HasForeignKey(d => d.HealthInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTestResult_HealthInstitution");

            entity.HasOne(d => d.ReportRegisterTest).WithMany(p => p.ReportRegisterTestResult)
                .HasForeignKey(d => d.ReportRegisterTestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTestResult_ReportRegisterTest");
        });

        modelBuilder.Entity<ReportingTimeType>(entity =>
        {
            entity.Property(e => e.ReportingTimeTypeId).HasColumnName("ReportingTimeTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportingTimeEn)
                .HasMaxLength(128)
                .HasColumnName("ReportingTime_EN");
            entity.Property(e => e.ReportingTimeSq)
                .HasMaxLength(128)
                .HasColumnName("ReportingTime_SQ");
            entity.Property(e => e.ReportingTimeSr)
                .HasMaxLength(128)
                .HasColumnName("ReportingTime_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportingTimeTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportingTimeType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportingTimeTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportingTimeType_AspNetUsers1");
        });

        modelBuilder.Entity<SampleTakenType>(entity =>
        {
            entity.Property(e => e.SampleTakenTypeId).HasColumnName("SampleTakenTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SampleTakenTypeEn)
                .HasMaxLength(128)
                .HasColumnName("SampleTakenType_EN");
            entity.Property(e => e.SampleTakenTypeSq)
                .HasMaxLength(128)
                .HasColumnName("SampleTakenType_SQ");
            entity.Property(e => e.SampleTakenTypeSr)
                .HasMaxLength(128)
                .HasColumnName("SampleTakenType_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SampleTakenTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SampleTakenType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SampleTakenTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SampleTakenType_AspNetUsers1");
        });

        modelBuilder.Entity<SearchIndicators>(entity =>
        {
            entity.HasKey(e => e.SearchKeyWordId).HasName("PK_SearchWord");

            entity.Property(e => e.SearchKeyWordId).HasColumnName("SearchKeyWordID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SearchKeyWord).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<SearchKeyWord>(entity =>
        {
            entity.HasKey(e => e.SearchIndicatorsId);

            entity.Property(e => e.SearchIndicatorsId).HasColumnName("SearchIndicatorsID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SearchIndicators).HasMaxLength(128);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<SearchResults>(entity =>
        {
            entity.HasKey(e => e.SearchResultId).HasName("PK_SearchResult");

            entity.Property(e => e.SearchResultId).HasColumnName("SearchResultID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.PublishDate).HasColumnType("datetime");
            entity.Property(e => e.SearchIndicators).HasMaxLength(256);
            entity.Property(e => e.Title).HasMaxLength(512);
            entity.Property(e => e.Url).HasColumnName("URL");
        });

        modelBuilder.Entity<SearchSourceSite>(entity =>
        {
            entity.HasKey(e => e.SearchSourceSiteId).HasName("PK_SearchSite");

            entity.Property(e => e.SearchSourceSiteId).HasColumnName("SearchSourceSiteID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SearchSourceSite1)
                .HasMaxLength(128)
                .HasColumnName("SearchSourceSite");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<Settlement>(entity =>
        {
            entity.HasKey(e => new { e.SettlementId, e.CityId });

            entity.ToTable("Settlement", "Core");

            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(256)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(256)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(256)
                .HasColumnName("Name_SR");
            entity.Property(e => e.NameTr)
                .HasMaxLength(256)
                .HasColumnName("Name_TR");

            entity.HasOne(d => d.City).WithMany(p => p.Settlement)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Settlement_City");
        });

        modelBuilder.Entity<StatusType>(entity =>
        {
            entity.Property(e => e.StatusTypeId).HasColumnName("StatusTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<SubMenu>(entity =>
        {
            entity.ToTable("SubMenu", "Core");

            entity.Property(e => e.SubmenuId).HasColumnName("SubmenuID");
            entity.Property(e => e.Action).HasMaxLength(128);
            entity.Property(e => e.Area).HasMaxLength(128);
            entity.Property(e => e.Claim).HasMaxLength(128);
            entity.Property(e => e.ClaimType).HasMaxLength(128);
            entity.Property(e => e.Controller).HasMaxLength(128);
            entity.Property(e => e.Icon).HasMaxLength(128);
            entity.Property(e => e.InsertedFrom).HasMaxLength(256);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.ParentSubId).HasColumnName("ParentSubID");
            entity.Property(e => e.Roles).HasMaxLength(1024);
            entity.Property(e => e.UpdatedFrom).HasMaxLength(256);

            entity.HasOne(d => d.Menu).WithMany(p => p.SubMenu)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubMenu_Menu");
        });

        modelBuilder.Entity<SurveyType>(entity =>
        {
            entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.SurveyType)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyType_DiseaseInfection");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SurveyTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SurveyTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SurveyType_AspNetUsers1");
        });

        modelBuilder.Entity<SurveyTypeTemp>(entity =>
        {
            entity.Property(e => e.SurveyTypeTempId).HasColumnName("SurveyTypeTempID");
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.SurveyTypeTemp)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyTypeTemp_DiseaseInfection");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SurveyTypeTempInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyTypeTemp_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SurveyTypeTempUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SurveyTypeTemp_AspNetUsers1");
        });

        modelBuilder.Entity<SyndromeType>(entity =>
        {
            entity.Property(e => e.SyndromeTypeId).HasColumnName("SyndromeTypeID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.NameEn)
                .HasMaxLength(128)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(128)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(128)
                .HasColumnName("Name_SR");
            entity.Property(e => e.ShortNameEn)
                .HasMaxLength(32)
                .HasColumnName("ShortName_EN");
            entity.Property(e => e.ShortNameSq)
                .HasMaxLength(32)
                .HasColumnName("ShortName_SQ");
            entity.Property(e => e.ShortNameSr)
                .HasMaxLength(32)
                .HasColumnName("ShortName_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SyndromeTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SyndromeType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SyndromeTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SyndromeType_AspNetUsers1");
        });

        modelBuilder.Entity<TestType>(entity =>
        {
            entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.TestName).HasMaxLength(128);
        });

        modelBuilder.Entity<UserAudit>(entity =>
        {
            entity.ToTable("UserAudit", "Core");

            entity.Property(e => e.UserAuditId).HasColumnName("UserAuditID");
            entity.Property(e => e.ActionEn)
                .HasMaxLength(450)
                .HasColumnName("Action_EN");
            entity.Property(e => e.ActionSq)
                .HasMaxLength(450)
                .HasColumnName("Action_SQ");
            entity.Property(e => e.ActionSr)
                .HasMaxLength(450)
                .HasColumnName("Action_SR");
            entity.Property(e => e.UserId).HasMaxLength(450);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
