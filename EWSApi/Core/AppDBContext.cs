
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EWSApi.Core;
public partial class AppDBContext : DbContext
{
    public AppDBContext()
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GenerateUniqueNumberResult> GenerateUniqueNumber { get; set; }

    public virtual DbSet<AgeGroup> AgeGroup { get; set; }

    public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<Bcgtype> Bcgtype { get; set; }

    public virtual DbSet<CaseClassificationType> CaseClassificationType { get; set; }

    public virtual DbSet<CitizenRegister> CitizenRegister { get; set; }

    public virtual DbSet<CitizenRegisterVaccine> CitizenRegisterVaccine { get; set; }

    public virtual DbSet<City> City { get; set; }

    public virtual DbSet<ClassificationCategoryType> ClassificationCategoryType { get; set; }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<DiseaseClassificationType> DiseaseClassificationType { get; set; }

    public virtual DbSet<DiseaseInfection> DiseaseInfection { get; set; }

    public virtual DbSet<DiseaseInfectionSurvey> DiseaseInfectionSurvey { get; set; }

    public virtual DbSet<DiseaseInfectionType> DiseaseInfectionType { get; set; }

    public virtual DbSet<DiseaseNotification> DiseaseNotification { get; set; }

    public virtual DbSet<DiseaseNotificationAspNetUser> DiseaseNotificationAspNetUser { get; set; }

    public virtual DbSet<DiseaseNotificationReportRegister> DiseaseNotificationReportRegister { get; set; }

    public virtual DbSet<DocumentType> DocumentType { get; set; }

    public virtual DbSet<Ethnicity> Ethnicity { get; set; }

    public virtual DbSet<Examination> Examination { get; set; }

    public virtual DbSet<ExtraPulmonarType> ExtraPulmonarType { get; set; }

    public virtual DbSet<Faqcategory> Faqcategory { get; set; }

    public virtual DbSet<FaqcategoryGroup> FaqcategoryGroup { get; set; }

    public virtual DbSet<Faqquestion> Faqquestion { get; set; }

    public virtual DbSet<FaqquestionStatus> FaqquestionStatus { get; set; }

    public virtual DbSet<Faqrate> Faqrate { get; set; }

    public virtual DbSet<Faqvideo> Faqvideo { get; set; }

    public virtual DbSet<Gender> Gender { get; set; }

    public virtual DbSet<HealthInstitution> HealthInstitution { get; set; }

    public virtual DbSet<HealthInstitutionLevel> HealthInstitutionLevel { get; set; }

    public virtual DbSet<Icd101> Icd101 { get; set; }

    public virtual DbSet<InstitucionetShendetsore> InstitucionetShendetsore { get; set; }

    public virtual DbSet<ListaInstitucioneveBhis> ListaInstitucioneveBhis { get; set; }

    public virtual DbSet<Log> Log { get; set; }

    public virtual DbSet<Manual> Manual { get; set; }

    public virtual DbSet<MedicalStaff> MedicalStaff { get; set; }

    public virtual DbSet<MedicalTreatmentType> MedicalTreatmentType { get; set; }

    public virtual DbSet<Menu> Menu { get; set; }

    public virtual DbSet<Nationality> Nationality { get; set; }

    public virtual DbSet<Notification> Notification { get; set; }

    public virtual DbSet<ProfessionType> ProfessionType { get; set; }

    public virtual DbSet<Quarter> Quarter { get; set; }

    public virtual DbSet<RealRole> RealRole { get; set; }

    public virtual DbSet<ReferenceType> ReferenceType { get; set; }

    public virtual DbSet<RegimenTreatmentType> RegimenTreatmentType { get; set; }

    public virtual DbSet<Region> Region { get; set; }

    public virtual DbSet<RegjistriIAnetareveOmk> RegjistriIAnetareveOmk { get; set; }

    public virtual DbSet<Report> Report { get; set; }

    public virtual DbSet<ReportRegister> ReportRegister { get; set; }

    public virtual DbSet<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; }

    public virtual DbSet<ReportRegisterConcomitantDisease> ReportRegisterConcomitantDisease { get; set; }

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

    public virtual DbSet<ReportRegisterTherapy> ReportRegisterTherapy { get; set; }

    public virtual DbSet<ReportRegisterTrackingStatus> ReportRegisterTrackingStatus { get; set; }

    public virtual DbSet<ReportRegisterTrackingStatusStaff> ReportRegisterTrackingStatusStaff { get; set; }

    public virtual DbSet<ReportRiskFactor> ReportRiskFactor { get; set; }

    public virtual DbSet<ReportRiskGroup> ReportRiskGroup { get; set; }

    public virtual DbSet<ReportSideEffect> ReportSideEffect { get; set; }

    public virtual DbSet<ReportStatus> ReportStatus { get; set; }

    public virtual DbSet<ReportingTimeType> ReportingTimeType { get; set; }

    public virtual DbSet<RiskFactorType> RiskFactorType { get; set; }

    public virtual DbSet<RiskGroupType> RiskGroupType { get; set; }

    public virtual DbSet<SampleTakenType> SampleTakenType { get; set; }

    public virtual DbSet<SearchIndicators> SearchIndicators { get; set; }

    public virtual DbSet<SearchResults> SearchResults { get; set; }

    public virtual DbSet<SearchSourceSite> SearchSourceSite { get; set; }

    public virtual DbSet<Settlement> Settlement { get; set; }

    public virtual DbSet<Sheet4> Sheet4 { get; set; }

    public virtual DbSet<SideEffectType> SideEffectType { get; set; }

    public virtual DbSet<SmsnPerdorues> SmsnPerdorues { get; set; }

    public virtual DbSet<StatusType> StatusType { get; set; }

    public virtual DbSet<SubMenu> SubMenu { get; set; }

    public virtual DbSet<SubSideEffectType> SubSideEffectType { get; set; }

    public virtual DbSet<SurveyModel> SurveyModel { get; set; }

    public virtual DbSet<SurveyModelTemp> SurveyModelTemp { get; set; }

    public virtual DbSet<SurveyType> SurveyType { get; set; }

    public virtual DbSet<SuspectedPlaceType> SuspectedPlaceType { get; set; }

    public virtual DbSet<SyndromeType> SyndromeType { get; set; }

    public virtual DbSet<TestType> TestType { get; set; }

    public virtual DbSet<TreatmentDetailType> TreatmentDetailType { get; set; }

    public virtual DbSet<TreatmentResultType> TreatmentResultType { get; set; }

    public virtual DbSet<TreatmentType> TreatmentType { get; set; }

    public virtual DbSet<UserAudit> UserAudit { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=dev;Database=EWS;user id=ateam_sql; password=Ateam.sql2019#; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<GenerateUniqueNumberResult>(e => e.HasNoKey());
        modelBuilder.Entity<AgeGroup>(entity =>
        {
            entity.Property(e => e.AgeGroupId).HasColumnName("AgeGroupID");
            entity.Property(e => e.AgeGroup1)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("AgeGroup");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(256);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(256);
        });

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
            entity.ToTable(tb => tb.IsTemporal(ttb =>
            {
                ttb.UseHistoryTable("AspNetUsers", "History");
                ttb
                    .HasPeriodStart("ValidFrom")
                    .HasColumnName("ValidFrom");
                ttb
                    .HasPeriodEnd("ValidTo")
                    .HasColumnName("ValidTo");
            }));

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

            entity.HasOne(d => d.HealthInstitution).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.HealthInstitutionId)
                .HasConstraintName("FK_AspNetUsers_HealthInstitution");

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

        modelBuilder.Entity<Bcgtype>(entity =>
        {
            entity.HasKey(e => e.BcgtypeId).HasName("PK__DCGType__49F8CAB4AFF05B3C");

            entity.ToTable("BCGType", "TB");

            entity.Property(e => e.BcgtypeId).HasColumnName("BCGTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.BcgtypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DCGType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.BcgtypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DCGType_AspNetUsers1");
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
            entity.Property(e => e.Birthdate).HasMaxLength(128);
            entity.Property(e => e.CountryId)
                .HasDefaultValueSql("((1))")
                .HasComment("The default value is 1 - Kosova")
                .HasColumnName("CountryID");
            entity.Property(e => e.Email).HasMaxLength(128);
            entity.Property(e => e.FatherName).HasMaxLength(128);
            entity.Property(e => e.Firstname).HasMaxLength(128);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Lastname).HasMaxLength(128);
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MotherName).HasMaxLength(128);
            entity.Property(e => e.Municipality).HasMaxLength(256);
            entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");
            entity.Property(e => e.PartnerName).HasMaxLength(128);
            entity.Property(e => e.PersonalNumber).HasMaxLength(128);
            entity.Property(e => e.PhoneNumber).HasMaxLength(128);
            entity.Property(e => e.Settlement).HasMaxLength(256);
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.Country).WithMany(p => p.CitizenRegister)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitizenRegister_Country");
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

            entity.HasOne(d => d.Region).WithMany(p => p.City)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_City_Region");
        });

        modelBuilder.Entity<ClassificationCategoryType>(entity =>
        {
            entity.HasKey(e => e.ClassificationCategoryTypeId).HasName("PK__Classifi__182836E627BF9FEC");

            entity.ToTable("ClassificationCategoryType", "TB");

            entity.Property(e => e.ClassificationCategoryTypeId).HasColumnName("ClassificationCategoryTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ClassificationCategoryTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassificationCategoryType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ClassificationCategoryTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ClassificationCategoryType_AspNetUsers1");
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

        modelBuilder.Entity<DiseaseClassificationType>(entity =>
        {
            entity.HasKey(e => e.DiseaseClassificationTypeId).HasName("PK__DiseaseC__C2A23587E9A2B6FE");

            entity.ToTable("DiseaseClassificationType", "TB");

            entity.Property(e => e.DiseaseClassificationTypeId).HasColumnName("DiseaseClassificationTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.DiseaseClassificationTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseClassificationType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.DiseaseClassificationTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DiseaseClassificationType_AspNetUsers1");
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
                .HasMaxLength(256)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(256)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(256)
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
                .HasConstraintName("FK_DiseaseInfection_ReportingTimeType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.DiseaseInfectionUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DiseaseInfection_AspNetUsers1");
        });

        modelBuilder.Entity<DiseaseInfectionSurvey>(entity =>
        {
            entity.Property(e => e.DiseaseInfectionSurveyId).HasColumnName("DiseaseInfectionSurveyID");
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SurveyModelId).HasColumnName("SurveyModelID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.DiseaseInfectionSurvey)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfectionSurvey_DiseaseInfection1");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.DiseaseInfectionSurveyInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfectionSurvey_AspNetUsers");

            entity.HasOne(d => d.SurveyModel).WithMany(p => p.DiseaseInfectionSurvey)
                .HasForeignKey(d => d.SurveyModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseInfectionSurvey_SurveyModel");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.DiseaseInfectionSurveyUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_DiseaseInfectionSurvey_AspNetUsers1");
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

        modelBuilder.Entity<DiseaseNotification>(entity =>
        {
            entity.ToTable("DiseaseNotification", "Core");

            entity.Property(e => e.DiseaseNotificationId).HasColumnName("DiseaseNotificationID");
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.From).HasColumnType("datetime");
            entity.Property(e => e.HealthInstitutionId).HasColumnName("HealthInstitutionID");
            entity.Property(e => e.Icon).HasMaxLength(128);
            entity.Property(e => e.To).HasColumnType("datetime");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .HasColumnName("URL");

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.DiseaseNotification)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotification_DiseaseInfection");

            entity.HasOne(d => d.HealthInstitution).WithMany(p => p.DiseaseNotification)
                .HasForeignKey(d => d.HealthInstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotification_HealthInstitution");
        });

        modelBuilder.Entity<DiseaseNotificationAspNetUser>(entity =>
        {
            entity.ToTable("DiseaseNotificationAspNetUser", "Core");

            entity.Property(e => e.DiseaseNotificationAspNetUserId).HasColumnName("DiseaseNotificationAspNetUserID");
            entity.Property(e => e.DiseaseNotificationId).HasColumnName("DiseaseNotificationID");
            entity.Property(e => e.UserId)
                .HasMaxLength(450)
                .HasColumnName("UserID");

            entity.HasOne(d => d.DiseaseNotification).WithMany(p => p.DiseaseNotificationAspNetUser)
                .HasForeignKey(d => d.DiseaseNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotificationAspNetUser_DiseaseNotification");

            entity.HasOne(d => d.User).WithMany(p => p.DiseaseNotificationAspNetUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotificationAspNetUser_AspNetUsers");
        });

        modelBuilder.Entity<DiseaseNotificationReportRegister>(entity =>
        {
            entity.ToTable("DiseaseNotificationReportRegister", "Core");

            entity.Property(e => e.DiseaseNotificationReportRegisterId).HasColumnName("DiseaseNotificationReportRegisterID");
            entity.Property(e => e.DiseaseNotificationId).HasColumnName("DiseaseNotificationID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");

            entity.HasOne(d => d.DiseaseNotification).WithMany(p => p.DiseaseNotificationReportRegister)
                .HasForeignKey(d => d.DiseaseNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotificationReportRegister_DiseaseInfection");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.DiseaseNotificationReportRegister)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiseaseNotificationReportRegister_ReportRegister");
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
            entity.Property(e => e.ExaminationId)
                .ValueGeneratedNever()
                .HasColumnName("ExaminationID");
            entity.Property(e => e.ExaminationCode).HasMaxLength(50);
            entity.Property(e => e.ExaminationName).HasMaxLength(100);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<ExtraPulmonarType>(entity =>
        {
            entity.HasKey(e => e.ExtraPulmonarTypeId).HasName("PK__ExtraPul__4C89FA0B662C0B22");

            entity.ToTable("ExtraPulmonarType", "TB");

            entity.Property(e => e.ExtraPulmonarTypeId).HasColumnName("ExtraPulmonarTypeID");
            entity.Property(e => e.DiseaseClassificationTypeId).HasColumnName("DiseaseClassificationTypeID");
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

            entity.HasOne(d => d.DiseaseClassificationType).WithMany(p => p.ExtraPulmonarType)
                .HasForeignKey(d => d.DiseaseClassificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExtraPulmonarType_DiseaseClassificationType");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ExtraPulmonarTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExtraPulmonarType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ExtraPulmonarTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ExtraPulmonarType_AspNetUsers1");
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
            entity.Property(e => e.Bhisid).HasColumnName("BHISid");
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
            entity.Property(e => e.Status).HasMaxLength(128);
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

        modelBuilder.Entity<Icd101>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IcdoriginCode }).HasName("PK_tblICD10_SISH");

            entity.ToTable("ICD10_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IcdoriginCode)
                .HasMaxLength(50)
                .HasColumnName("ICDOriginCode");
            entity.Property(e => e.TitleSq)
                .HasMaxLength(550)
                .HasColumnName("TitleSQ");
        });

        modelBuilder.Entity<InstitucionetShendetsore>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Adresa).HasMaxLength(50);
            entity.Property(e => e.BhisId).HasColumnName("BHisID");
            entity.Property(e => e.Emri).HasMaxLength(500);
            entity.Property(e => e.Komuna).HasMaxLength(50);
            entity.Property(e => e.KomunaId).HasColumnName("KomunaID");
            entity.Property(e => e.Niveli).HasMaxLength(500);
            entity.Property(e => e.Vendi).HasMaxLength(50);
            entity.Property(e => e.VendiId).HasColumnName("VendiID");
        });

        modelBuilder.Entity<ListaInstitucioneveBhis>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListaInstitucioneveBHIS");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.IdParent)
                .HasMaxLength(50)
                .HasColumnName("ID_Parent");
            entity.Property(e => e.Institucioni).HasMaxLength(50);
            entity.Property(e => e.Institucioni2).HasMaxLength(50);
            entity.Property(e => e.Komuna).HasMaxLength(50);
            entity.Property(e => e.Niveli).HasMaxLength(50);
            entity.Property(e => e.Shtohet).HasMaxLength(50);
            entity.Property(e => e.Smsnid)
                .HasMaxLength(50)
                .HasColumnName("SMSNID");
            entity.Property(e => e.Vendi).HasMaxLength(50);
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

        modelBuilder.Entity<Manual>(entity =>
        {
            entity.Property(e => e.ManualId).HasColumnName("ManualID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.PathEn)
                .HasMaxLength(1024)
                .HasColumnName("Path_EN");
            entity.Property(e => e.PathSq)
                .HasMaxLength(1024)
                .HasColumnName("Path_SQ");
            entity.Property(e => e.PathSr)
                .HasMaxLength(1024)
                .HasColumnName("Path_SR");
            entity.Property(e => e.RoleId)
                .HasMaxLength(450)
                .HasColumnName("RoleID");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(128)
                .HasColumnName("Title_EN");
            entity.Property(e => e.TitleSq)
                .HasMaxLength(128)
                .HasColumnName("Title_SQ");
            entity.Property(e => e.TitleSr)
                .HasMaxLength(128)
                .HasColumnName("Title_SR");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ManualInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manual_AspNetUsers");

            entity.HasOne(d => d.Role).WithMany(p => p.Manual)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manual_AspNetRoles");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ManualUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_Manual_AspNetUsers1");
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
            entity.Property(e => e.PersonalNumber).HasMaxLength(64);
            entity.Property(e => e.Specialization).HasMaxLength(256);
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
        });

        modelBuilder.Entity<MedicalTreatmentType>(entity =>
        {
            entity.HasKey(e => e.MedicalTreatmentTypeId).HasName("PK__Institut__2677D211D4DCC85D");

            entity.ToTable("MedicalTreatmentType", "TB");

            entity.Property(e => e.MedicalTreatmentTypeId).HasColumnName("MedicalTreatmentTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.MedicalTreatmentTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitutionType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.MedicalTreatmentTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_InstitutionType_AspNetUsers1");
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

        modelBuilder.Entity<Quarter>(entity =>
        {
            entity.HasKey(e => e.QuarterId).HasName("PK__Quarter__1D2BD182A0D6C744");

            entity.ToTable("Quarter", "TB");

            entity.Property(e => e.QuarterId).HasColumnName("QuarterID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.QuarterInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quarter_Quarter");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.QuarterUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_Quarter_AspNetUsers");
        });

        modelBuilder.Entity<RealRole>(entity =>
        {
            entity.ToTable("RealRole", "Core");

            entity.Property(e => e.RealRoleId).HasColumnName("RealRoleID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.RoleId)
                .HasMaxLength(450)
                .HasColumnName("RoleID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
            entity.Property(e => e.UserId)
                .HasMaxLength(450)
                .HasColumnName("UserID");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.RealRoleInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RealRole_AspNetUsers");

            entity.HasOne(d => d.Role).WithMany(p => p.RealRole)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RealRole_AspNetRoles");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.RealRoleUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_RealRole_AspNetUsers1");

            entity.HasOne(d => d.User).WithMany(p => p.RealRoleUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RealRole_AspNetUsers2");
        });

        modelBuilder.Entity<ReferenceType>(entity =>
        {
            entity.HasKey(e => e.ReferenceTypeId).HasName("PK__Referenc__573016EA29FE157C");

            entity.ToTable("ReferenceType", "TB");

            entity.Property(e => e.ReferenceTypeId).HasColumnName("ReferenceTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReferenceTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReferenceType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReferenceTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReferenceType_AspNetUsers1");
        });

        modelBuilder.Entity<RegimenTreatmentType>(entity =>
        {
            entity.HasKey(e => e.RegimenTreatmentTypeId).HasName("PK__RegimenT__A25E1E551AA458C1");

            entity.ToTable("RegimenTreatmentType", "TB");

            entity.Property(e => e.RegimenTreatmentTypeId).HasColumnName("RegimenTreatmentTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.RegimenTreatmentTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegimenTreatmentType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.RegimenTreatmentTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_RegimenTreatmentType_AspNetUsers1");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("Region", "Core");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.RegionNavigation)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Region_City");
        });

        modelBuilder.Entity<RegjistriIAnetareveOmk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Regjistri i anetareve OMK");

            entity.Property(e => e.Column10)
                .HasMaxLength(1)
                .HasColumnName("column10");
            entity.Property(e => e.Column11)
                .HasMaxLength(1)
                .HasColumnName("column11");
            entity.Property(e => e.Column12)
                .HasMaxLength(1)
                .HasColumnName("column12");
            entity.Property(e => e.Column13)
                .HasMaxLength(1)
                .HasColumnName("column13");
            entity.Property(e => e.Emri).HasMaxLength(100);
            entity.Property(e => e.KodiILicencS)
                .HasMaxLength(100)
                .HasColumnName("Kodi_i_licenc_s");
            entity.Property(e => e.KodiILicencSSDyt2)
                .HasMaxLength(100)
                .HasColumnName("Kodi_i_licenc_s_s_dyt_2");
            entity.Property(e => e.Mbiemri).HasMaxLength(100);
            entity.Property(e => e.NrRendor).HasColumnName("Nr_rendor");
            entity.Property(e => e.NumriPersonal)
                .HasMaxLength(100)
                .HasColumnName("Numri_personal");
            entity.Property(e => e.StatusiProfesional)
                .HasMaxLength(100)
                .HasColumnName("Statusi_Profesional");
            entity.Property(e => e.StatusiProfesionalSDyt2)
                .HasMaxLength(100)
                .HasColumnName("Statusi_Profesional_s_dyt_2");
            entity.Property(e => e.StatutiILicencS)
                .HasMaxLength(100)
                .HasColumnName("Statuti_i_licenc_s");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__Report__D5BD48E5C4CCC35A");

            entity.ToTable("Report", "TB");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.Address).HasMaxLength(128);
            entity.Property(e => e.BcgtypeId).HasColumnName("BCGTypeID");
            entity.Property(e => e.Birthdate).HasMaxLength(128);
            entity.Property(e => e.CitizenRegisterId).HasColumnName("CitizenRegisterID");
            entity.Property(e => e.ClassificationCategoryTypeId).HasColumnName("ClassificationCategoryTypeID");
            entity.Property(e => e.ContactPersonAddress).HasMaxLength(256);
            entity.Property(e => e.ContactPersonName).HasMaxLength(256);
            entity.Property(e => e.ContactPersonPhoneNumber).HasMaxLength(32);
            entity.Property(e => e.DiseaseClassificationTypeId).HasColumnName("DiseaseClassificationTypeID");
            entity.Property(e => e.Drugs).HasMaxLength(256);
            entity.Property(e => e.ExtraPulmonarTypeId).HasColumnName("ExtraPulmonarTypeID");
            entity.Property(e => e.FatherName).HasMaxLength(128);
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.IltbchemoCompleteNumber).HasColumnName("ILTBChemoCompleteNumber");
            entity.Property(e => e.IltbchemoNumber).HasColumnName("ILTBChemoNumber");
            entity.Property(e => e.Iltbnumber).HasColumnName("ILTBNumber");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MedicalStaffId).HasColumnName("MedicalStaffID");
            entity.Property(e => e.MedicalTreatmentTypeId).HasColumnName("MedicalTreatmentTypeID");
            entity.Property(e => e.MotherName).HasMaxLength(128);
            entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");
            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.PeronalNumber)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Ppdnumber).HasColumnName("PPDNumber");
            entity.Property(e => e.QuarterId).HasColumnName("QuarterID");
            entity.Property(e => e.ReferenceTypeId).HasColumnName("ReferenceTypeID");
            entity.Property(e => e.RegimenTreatmentTypeId).HasColumnName("RegimenTreatmentTypeID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.ReportNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Rtgnumber).HasColumnName("RTGNumber");
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.SideEffectTypeId).HasColumnName("SideEffectTypeID");
            entity.Property(e => e.TreatmentDetailTypeId).HasColumnName("TreatmentDetailTypeID");
            entity.Property(e => e.TreatmentResultTypeId).HasColumnName("TreatmentResultTypeID");
            entity.Property(e => e.TreatmentStartDate).HasColumnType("datetime");
            entity.Property(e => e.TreatmentTypeId).HasColumnName("TreatmentTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Bcgtype).WithMany(p => p.Report)
                .HasForeignKey(d => d.BcgtypeId)
                .HasConstraintName("FK_Report_BCGType");

            entity.HasOne(d => d.CitizenRegister).WithMany(p => p.Report)
                .HasForeignKey(d => d.CitizenRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_CitizenRegister");

            entity.HasOne(d => d.ClassificationCategoryType).WithMany(p => p.Report)
                .HasForeignKey(d => d.ClassificationCategoryTypeId)
                .HasConstraintName("FK_Report_ClassificationCategoryType");

            entity.HasOne(d => d.DiseaseClassificationType).WithMany(p => p.Report)
                .HasForeignKey(d => d.DiseaseClassificationTypeId)
                .HasConstraintName("FK_Report_DiseaseClassificationType");

            entity.HasOne(d => d.ExtraPulmonarType).WithMany(p => p.Report)
                .HasForeignKey(d => d.ExtraPulmonarTypeId)
                .HasConstraintName("FK_Report_ExtraPulmonarType");

            entity.HasOne(d => d.Gender).WithMany(p => p.Report)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_Gender");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_AspNetUsers");

            entity.HasOne(d => d.MedicalStaff).WithMany(p => p.Report)
                .HasForeignKey(d => d.MedicalStaffId)
                .HasConstraintName("FK_Report_MedicalStaff");

            entity.HasOne(d => d.MedicalTreatmentType).WithMany(p => p.Report)
                .HasForeignKey(d => d.MedicalTreatmentTypeId)
                .HasConstraintName("FK_Report_InstitutionType");

            entity.HasOne(d => d.Municipality).WithMany(p => p.Report)
                .HasForeignKey(d => d.MunicipalityId)
                .HasConstraintName("FK_Report_City");

            entity.HasOne(d => d.Nationality).WithMany(p => p.Report)
                .HasForeignKey(d => d.NationalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_Nationality");

            entity.HasOne(d => d.Quarter).WithMany(p => p.Report)
                .HasForeignKey(d => d.QuarterId)
                .HasConstraintName("FK_Report_Quarter");

            entity.HasOne(d => d.ReferenceType).WithMany(p => p.Report)
                .HasForeignKey(d => d.ReferenceTypeId)
                .HasConstraintName("FK_Report_ReferenceType");

            entity.HasOne(d => d.RegimenTreatmentType).WithMany(p => p.Report)
                .HasForeignKey(d => d.RegimenTreatmentTypeId)
                .HasConstraintName("FK_Report_RegimenTreatmentType");

            entity.HasOne(d => d.Region).WithMany(p => p.Report)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Report_Region");

            entity.HasOne(d => d.SideEffectType).WithMany(p => p.Report)
                .HasForeignKey(d => d.SideEffectTypeId)
                .HasConstraintName("FK_Report_SideEffectType");

            entity.HasOne(d => d.TreatmentDetailType).WithMany(p => p.Report)
                .HasForeignKey(d => d.TreatmentDetailTypeId)
                .HasConstraintName("FK_Report_TreatmentDetailType");

            entity.HasOne(d => d.TreatmentResultType).WithMany(p => p.Report)
                .HasForeignKey(d => d.TreatmentResultTypeId)
                .HasConstraintName("FK_Report_TreatmentResultType");

            entity.HasOne(d => d.TreatmentType).WithMany(p => p.Report)
                .HasForeignKey(d => d.TreatmentTypeId)
                .HasConstraintName("FK_Report_TreatmentType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_Report_AspNetUsers1");

            entity.HasOne(d => d.Settlement).WithMany(p => p.Report)
                .HasForeignKey(d => new { d.SettlementId, d.MunicipalityId })
                .HasConstraintName("FK_Report_Settlement");
        });

        modelBuilder.Entity<ReportRegister>(entity =>
        {
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.Address).HasMaxLength(256);
            entity.Property(e => e.Birthdate).HasMaxLength(128);
            entity.Property(e => e.CitizenRegisterId).HasColumnName("CitizenRegisterID");
            entity.Property(e => e.ConsultingDate).HasColumnType("datetime");
            entity.Property(e => e.FatherName).HasMaxLength(128);
            entity.Property(e => e.Firstname).HasMaxLength(128);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HealthInstitutionAddress).HasMaxLength(256);
            entity.Property(e => e.HealthInstitutionId).HasColumnName("HealthInstitutionID");
            entity.Property(e => e.HealthInstitutionName).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.Lastname).HasMaxLength(128);
            entity.Property(e => e.MotherName).HasMaxLength(128);
            entity.Property(e => e.PartnerName).HasMaxLength(128);
            entity.Property(e => e.PatientCode)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.PersonalNumber).HasMaxLength(128);
            entity.Property(e => e.PhoneNumber).HasMaxLength(128);
            entity.Property(e => e.ProfessionTypeId).HasColumnName("ProfessionTypeID");
            entity.Property(e => e.SuspectedPlace).HasMaxLength(50);
            entity.Property(e => e.SuspectedPlaceTypeId).HasColumnName("SuspectedPlaceTypeID");
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

            entity.HasOne(d => d.Gender).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegister_Gender");

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

            entity.HasOne(d => d.SuspectedPlaceType).WithMany(p => p.ReportRegister)
                .HasForeignKey(d => d.SuspectedPlaceTypeId)
                .HasConstraintName("FK_ReportRegister_SuspectedPlaceType");

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

        modelBuilder.Entity<ReportRegisterConcomitantDisease>(entity =>
        {
            entity.Property(e => e.ReportRegisterConcomitantDiseaseId).HasColumnName("ReportRegisterConcomitantDiseaseID");
            entity.Property(e => e.DiseaseInfectionId).HasColumnName("DiseaseInfectionID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.DiseaseInfection).WithMany(p => p.ReportRegisterConcomitantDisease)
                .HasForeignKey(d => d.DiseaseInfectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterConcomitantDisease_DiseaseInfection");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterConcomitantDiseaseInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterConcomitantDisease_AspNetUsers");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterConcomitantDisease)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterConcomitantDisease_ReportRegister");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterConcomitantDiseaseUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterConcomitantDisease_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterContact>(entity =>
        {
            entity.Property(e => e.ReportRegisterContactId).HasColumnName("ReportRegisterContactID");
            entity.Property(e => e.BirthDate).HasMaxLength(128);
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.PersonalNumber).HasMaxLength(128);
            entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");
            entity.Property(e => e.Relationship).HasMaxLength(128);
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
            entity.Property(e => e.SurveyNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
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
            entity.Property(e => e.Description).HasMaxLength(128);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.SampleTakenDate).HasColumnType("datetime");
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
            entity.Property(e => e.Department).HasMaxLength(128);
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
            entity.Property(e => e.SurveyNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
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
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
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

        modelBuilder.Entity<ReportRegisterTherapy>(entity =>
        {
            entity.HasKey(e => e.ReportRegisterTherapyId).HasName("PK_ReportRegisterStatusTherapy");

            entity.Property(e => e.ReportRegisterTherapyId).HasColumnName("ReportRegisterTherapyID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.MedicalStaffId).HasColumnName("MedicalStaffID");
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.Therapy).HasMaxLength(128);
            entity.Property(e => e.UpdatedByMedicalStaffId).HasColumnName("UpdatedByMedicalStaffID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterTherapyInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatusTherapy_AspNetUsers");

            entity.HasOne(d => d.MedicalStaff).WithMany(p => p.ReportRegisterTherapyMedicalStaff)
                .HasForeignKey(d => d.MedicalStaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTherapy_MedicalStaff");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterTherapy)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterStatusTherapy_ReportRegisterStatus");

            entity.HasOne(d => d.UpdatedByMedicalStaff).WithMany(p => p.ReportRegisterTherapyUpdatedByMedicalStaff)
                .HasForeignKey(d => d.UpdatedByMedicalStaffId)
                .HasConstraintName("FK_ReportRegisterTherapy_MedicalStaff1");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRegisterTherapyUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRegisterStatusTherapy_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRegisterTrackingStatus>(entity =>
        {
            entity.Property(e => e.ReportRegisterTrackingStatusId).HasColumnName("ReportRegisterTrackingStatusID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterId).HasColumnName("ReportRegisterID");
            entity.Property(e => e.StatusTypeId).HasColumnName("StatusTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterTrackingStatus)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTrackingStatus_AspNetUsers");

            entity.HasOne(d => d.ReportRegister).WithMany(p => p.ReportRegisterTrackingStatus)
                .HasForeignKey(d => d.ReportRegisterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTrackingStatus_ReportRegister");

            entity.HasOne(d => d.StatusType).WithMany(p => p.ReportRegisterTrackingStatus)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTrackingStatus_StatusType");
        });

        modelBuilder.Entity<ReportRegisterTrackingStatusStaff>(entity =>
        {
            entity.Property(e => e.ReportRegisterTrackingStatusStaffId).HasColumnName("ReportRegisterTrackingStatusStaffID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportRegisterTrackingStatusId).HasColumnName("ReportRegisterTrackingStatusID");
            entity.Property(e => e.UserId)
                .HasMaxLength(450)
                .HasColumnName("UserID");

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRegisterTrackingStatusStaffInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTrackingStatusStaff_AspNetUsers");

            entity.HasOne(d => d.ReportRegisterTrackingStatus).WithMany(p => p.ReportRegisterTrackingStatusStaff)
                .HasForeignKey(d => d.ReportRegisterTrackingStatusId)
                .HasConstraintName("FK_ReportRegisterTrackingStatusStaff_ReportRegisterTrackingStatus");

            entity.HasOne(d => d.User).WithMany(p => p.ReportRegisterTrackingStatusStaffUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRegisterTrackingStatusStaff_ReportRegisterTrackingStatusStaff");
        });

        modelBuilder.Entity<ReportRiskFactor>(entity =>
        {
            entity.HasKey(e => e.ReportRiskFactorId).HasName("PK__ReportRi__5EC62F2E38F63F18");

            entity.ToTable("ReportRiskFactor", "TB");

            entity.Property(e => e.ReportRiskFactorId).HasColumnName("ReportRiskFactorID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.RiskFactorTypeId).HasColumnName("RiskFactorTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRiskFactorInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskFactor_AspNetUsers");

            entity.HasOne(d => d.Report).WithMany(p => p.ReportRiskFactor)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskFactor_Report");

            entity.HasOne(d => d.RiskFactorType).WithMany(p => p.ReportRiskFactor)
                .HasForeignKey(d => d.RiskFactorTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskFactor_RiskFactorType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRiskFactorUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRiskFactor_AspNetUsers1");
        });

        modelBuilder.Entity<ReportRiskGroup>(entity =>
        {
            entity.HasKey(e => e.ReportRiskGroupId).HasName("PK__ReportRi__23DE2A048ADE9DEA");

            entity.ToTable("ReportRiskGroup", "TB");

            entity.Property(e => e.ReportRiskGroupId).HasColumnName("ReportRiskGroupID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.RiskGroupTypeId).HasColumnName("RiskGroupTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportRiskGroupInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskGroup_AspNetUsers");

            entity.HasOne(d => d.Report).WithMany(p => p.ReportRiskGroup)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskGroup_Report");

            entity.HasOne(d => d.RiskGroupType).WithMany(p => p.ReportRiskGroup)
                .HasForeignKey(d => d.RiskGroupTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportRiskGroup_RiskGroupType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportRiskGroupUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportRiskGroup_AspNetUsers1");
        });

        modelBuilder.Entity<ReportSideEffect>(entity =>
        {
            entity.HasKey(e => e.ReportSideEffectId).HasName("PK__ReportSi__08952537D43C968A");

            entity.ToTable("ReportSideEffect", "TB");

            entity.Property(e => e.ReportSideEffectId).HasColumnName("ReportSideEffectID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.SubSideEffectTypeId).HasColumnName("SubSideEffectTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportSideEffectInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportSideEffect_AspNetUsers");

            entity.HasOne(d => d.Report).WithMany(p => p.ReportSideEffect)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportSideEffect_Report");

            entity.HasOne(d => d.SubSideEffectType).WithMany(p => p.ReportSideEffect)
                .HasForeignKey(d => d.SubSideEffectTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportSideEffect_SubSideEffectType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportSideEffectUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportSideEffect_AspNetUsers1");
        });

        modelBuilder.Entity<ReportStatus>(entity =>
        {
            entity.HasKey(e => e.ReportStatusId).HasName("PK_ReportRegisterStatus");

            entity.ToTable("ReportStatus", "TB");

            entity.Property(e => e.ReportStatusId).HasColumnName("ReportStatusID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.ReportStatusTypeId).HasColumnName("ReportStatusTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.ReportStatusInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportStatus_AspNetUsers");

            entity.HasOne(d => d.Report).WithMany(p => p.ReportStatus)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportStatus_Report");

            entity.HasOne(d => d.ReportStatusType).WithMany(p => p.ReportStatus)
                .HasForeignKey(d => d.ReportStatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportStatus_StatusType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.ReportStatusUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_ReportStatus_AspNetUsers1");
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

        modelBuilder.Entity<RiskFactorType>(entity =>
        {
            entity.HasKey(e => e.RiskFactorTypeId).HasName("PK__RiskFact__747947E76E80BAA6");

            entity.ToTable("RiskFactorType", "TB");

            entity.Property(e => e.RiskFactorTypeId).HasColumnName("RiskFactorTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.RiskFactorTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFactorType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.RiskFactorTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_RiskFactorType_AspNetUsers1");
        });

        modelBuilder.Entity<RiskGroupType>(entity =>
        {
            entity.HasKey(e => e.RiskGroupTypeId).HasName("PK__RiskGrou__27F5CA7012A4C3AF");

            entity.ToTable("RiskGroupType", "TB");

            entity.Property(e => e.RiskGroupTypeId).HasColumnName("RiskGroupTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.RiskGroupTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskGroupType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.RiskGroupTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_RiskGroupType_AspNetUsers1");
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

        modelBuilder.Entity<SearchResults>(entity =>
        {
            entity.HasKey(e => e.SearchResultId).HasName("PK_SearchResult");

            entity.Property(e => e.SearchResultId).HasColumnName("SearchResultID");
            entity.Property(e => e.Description).HasMaxLength(512);
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

        modelBuilder.Entity<Sheet4>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.HealthInstitutionLevelId).HasColumnName("HealthInstitutionLevelID");
            entity.Property(e => e.IdentificationNumber).HasMaxLength(255);
            entity.Property(e => e.LicenceNumber).HasMaxLength(255);
            entity.Property(e => e.MinicipalityId).HasColumnName("MinicipalityID");
            entity.Property(e => e.NameEn)
                .HasMaxLength(255)
                .HasColumnName("Name_EN");
            entity.Property(e => e.NameSq)
                .HasMaxLength(255)
                .HasColumnName("Name_SQ");
            entity.Property(e => e.NameSr)
                .HasMaxLength(255)
                .HasColumnName("Name_SR");
            entity.Property(e => e.SettlementId).HasColumnName("SettlementID");
            entity.Property(e => e.ShortNameEn)
                .HasMaxLength(255)
                .HasColumnName("ShortName_EN");
            entity.Property(e => e.ShortNameSq)
                .HasMaxLength(255)
                .HasColumnName("ShortName_SQ");
            entity.Property(e => e.ShortNameSr)
                .HasMaxLength(255)
                .HasColumnName("ShortName_SR");
            entity.Property(e => e.Status).HasMaxLength(255);
        });

        modelBuilder.Entity<SideEffectType>(entity =>
        {
            entity.HasKey(e => e.SideEffectTypeId).HasName("PK__SideEffe__5160496FDCDFA5D1");

            entity.ToTable("SideEffectType", "TB");

            entity.Property(e => e.SideEffectTypeId).HasColumnName("SideEffectTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SideEffectTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SideEffectType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SideEffectTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SideEffectType_AspNetUsers1");
        });

        modelBuilder.Entity<SmsnPerdorues>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMSN perdorues");

            entity.Property(e => e.EmailAdresa)
                .HasMaxLength(50)
                .HasColumnName("Email_adresa");
            entity.Property(e => e.Emri).HasMaxLength(50);
            entity.Property(e => e.Institution).HasMaxLength(50);
            entity.Property(e => e.Mbiemri).HasMaxLength(50);
            entity.Property(e => e.NrPersonal)
                .HasMaxLength(50)
                .HasColumnName("Nr_Personal");
            entity.Property(e => e.NrTel)
                .HasMaxLength(50)
                .HasColumnName("Nr_Tel");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Specializim)
                .HasMaxLength(50)
                .HasColumnName("specializim");
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

        modelBuilder.Entity<SubSideEffectType>(entity =>
        {
            entity.HasKey(e => e.SubSideEffectTypeId).HasName("PK__SubSideE__B3CF8F7BF0D761A7");

            entity.ToTable("SubSideEffectType", "TB");

            entity.Property(e => e.SubSideEffectTypeId).HasColumnName("SubSideEffectTypeID");
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
            entity.Property(e => e.SideEffectTypeId).HasColumnName("SideEffectTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SubSideEffectTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubSideEffectType_AspNetUsers");

            entity.HasOne(d => d.SideEffectType).WithMany(p => p.SubSideEffectType)
                .HasForeignKey(d => d.SideEffectTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubSideEffectType_SideEffectType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SubSideEffectTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SubSideEffectType_AspNetUsers1");
        });

        modelBuilder.Entity<SurveyModel>(entity =>
        {
            entity.HasKey(e => e.SurveyModelId).HasName("PK_SurveyType");

            entity.Property(e => e.SurveyModelId).HasColumnName("SurveyModelID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SurveyModelInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyModel_AspNetUsers");

            entity.HasOne(d => d.SurveyType).WithMany(p => p.SurveyModel)
                .HasForeignKey(d => d.SurveyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyModel_SurveyType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SurveyModelUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SurveyModel_AspNetUsers1");
        });

        modelBuilder.Entity<SurveyModelTemp>(entity =>
        {
            entity.HasKey(e => e.SurveyModelTempId).HasName("PK_SurveyTypeTemp");

            entity.Property(e => e.SurveyModelTempId).HasColumnName("SurveyModelTempID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom).HasMaxLength(450);
            entity.Property(e => e.RowId).HasColumnName("RowID");
            entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom).HasMaxLength(450);

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.SurveyModelTempInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyModelTemp_AspNetUsers");

            entity.HasOne(d => d.SurveyType).WithMany(p => p.SurveyModelTemp)
                .HasForeignKey(d => d.SurveyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyModelTemp_SurveyType");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.SurveyModelTempUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_SurveyModelTemp_AspNetUsers1");
        });

        modelBuilder.Entity<SurveyType>(entity =>
        {
            entity.HasKey(e => e.SurveyTypeId).HasName("PK_SurveyType_1");

            entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");
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

        modelBuilder.Entity<SuspectedPlaceType>(entity =>
        {
            entity.Property(e => e.SuspectedPlaceTypeId).HasColumnName("SuspectedPlaceTypeID");
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

        modelBuilder.Entity<TreatmentDetailType>(entity =>
        {
            entity.HasKey(e => e.TreatmentDetailTypeId).HasName("PK__Treatmen__DC67CDC8A1650ACD");

            entity.ToTable("TreatmentDetailType", "TB");

            entity.Property(e => e.TreatmentDetailTypeId).HasColumnName("TreatmentDetailTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.TreatmentDetailTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreatmentDetailTypeID_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.TreatmentDetailTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_TreatmentDetailTypeID_AspNetUsers1");
        });

        modelBuilder.Entity<TreatmentResultType>(entity =>
        {
            entity.HasKey(e => e.TreatmentDetailTypeId).HasName("PK__Treatmen__DC67CDC88FC2ED7F");

            entity.ToTable("TreatmentResultType", "TB");

            entity.Property(e => e.TreatmentDetailTypeId).HasColumnName("TreatmentDetailTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.TreatmentResultTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreatmentResultType_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.TreatmentResultTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_TreatmentResultType_AspNetUsers1");
        });

        modelBuilder.Entity<TreatmentType>(entity =>
        {
            entity.HasKey(e => e.TreatmentTypeId).HasName("PK__Treatmen__F3EDE1799A892062");

            entity.ToTable("TreatmentType", "TB");

            entity.Property(e => e.TreatmentTypeId).HasColumnName("TreatmentTypeID");
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

            entity.HasOne(d => d.InsertedFromNavigation).WithMany(p => p.TreatmentTypeInsertedFromNavigation)
                .HasForeignKey(d => d.InsertedFrom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TreatmentTypeID_AspNetUsers");

            entity.HasOne(d => d.UpdatedFromNavigation).WithMany(p => p.TreatmentTypeUpdatedFromNavigation)
                .HasForeignKey(d => d.UpdatedFrom)
                .HasConstraintName("FK_TreatmentTypeID_AspNetUsers1");
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