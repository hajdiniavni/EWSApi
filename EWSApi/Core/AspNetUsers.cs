using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class AspNetUsers
{
    public string Id { get; set; } = null!;

    public int? HealthInstitutionId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Lastname { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public int? CityId { get; set; }

    public int? SettlementId { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public DateTime PasswordExpires { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public bool? AllowAdminNotification { get; set; }

    public bool? AllowNotifications { get; set; }

    public string? GoogleToken { get; set; }

    public int Mode { get; set; }

    public int Language { get; set; }

    public bool? Active { get; set; }

    public DateTime InsertedDate { get; set; }

    public string? InsertedFrom { get; set; }

    public string? ImageProfile { get; set; }

    public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; } = new List<AspNetUserClaims>();

    public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; } = new List<AspNetUserLogins>();

    public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; } = new List<AspNetUserTokens>();

    public virtual ICollection<DiseaseInfection> DiseaseInfectionInsertedFromNavigation { get; set; } = new List<DiseaseInfection>();

    public virtual ICollection<DiseaseInfectionSurvey> DiseaseInfectionSurveyInsertedFromNavigation { get; set; } = new List<DiseaseInfectionSurvey>();

    public virtual ICollection<DiseaseInfectionSurvey> DiseaseInfectionSurveyUpdatedFromNavigation { get; set; } = new List<DiseaseInfectionSurvey>();

    public virtual ICollection<DiseaseInfectionType> DiseaseInfectionTypeInsertedFromNavigation { get; set; } = new List<DiseaseInfectionType>();

    public virtual ICollection<DiseaseInfectionType> DiseaseInfectionTypeUpdatedFromNavigation { get; set; } = new List<DiseaseInfectionType>();

    public virtual ICollection<DiseaseInfection> DiseaseInfectionUpdatedFromNavigation { get; set; } = new List<DiseaseInfection>();

    public virtual ICollection<Faqcategory> Faqcategory { get; set; } = new List<Faqcategory>();

    public virtual HealthInstitution? HealthInstitution { get; set; }

    public virtual ICollection<HealthInstitution> HealthInstitutionInsertedFromNavigation { get; set; } = new List<HealthInstitution>();

    public virtual ICollection<HealthInstitutionLevel> HealthInstitutionLevelInsertedFromNavigation { get; set; } = new List<HealthInstitutionLevel>();

    public virtual ICollection<HealthInstitutionLevel> HealthInstitutionLevelUpdatedFromNavigation { get; set; } = new List<HealthInstitutionLevel>();

    public virtual ICollection<HealthInstitution> HealthInstitutionUpdatedFromNavigation { get; set; } = new List<HealthInstitution>();

    public virtual ICollection<Log> Log { get; set; } = new List<Log>();

    public virtual ICollection<RealRole> RealRoleInsertedFromNavigation { get; set; } = new List<RealRole>();

    public virtual ICollection<RealRole> RealRoleUpdatedFromNavigation { get; set; } = new List<RealRole>();

    public virtual ICollection<RealRole> RealRoleUser { get; set; } = new List<RealRole>();

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassificationInsertedFromNavigation { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassificationUpdatedFromNavigation { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual ICollection<ReportRegisterConcomitantDisease> ReportRegisterConcomitantDiseaseInsertedFromNavigation { get; set; } = new List<ReportRegisterConcomitantDisease>();

    public virtual ICollection<ReportRegisterConcomitantDisease> ReportRegisterConcomitantDiseaseUpdatedFromNavigation { get; set; } = new List<ReportRegisterConcomitantDisease>();

    public virtual ICollection<ReportRegisterContact> ReportRegisterContactInsertedFromNavigation { get; set; } = new List<ReportRegisterContact>();

    public virtual ICollection<ReportRegisterContactSurvey> ReportRegisterContactSurveyInsertedFromNavigation { get; set; } = new List<ReportRegisterContactSurvey>();

    public virtual ICollection<ReportRegisterContactSurvey> ReportRegisterContactSurveyUpdatedFromNavigation { get; set; } = new List<ReportRegisterContactSurvey>();

    public virtual ICollection<ReportRegisterContact> ReportRegisterContactUpdatedFromNavigation { get; set; } = new List<ReportRegisterContact>();

    public virtual ICollection<ReportRegister> ReportRegisterInsertedFromNavigation { get; set; } = new List<ReportRegister>();

    public virtual ICollection<ReportRegisterReference> ReportRegisterReferenceInsertedFromNavigation { get; set; } = new List<ReportRegisterReference>();

    public virtual ICollection<ReportRegisterReference> ReportRegisterReferenceUpdatedFromNavigation { get; set; } = new List<ReportRegisterReference>();

    public virtual ICollection<ReportRegisterSampleTaken> ReportRegisterSampleTakenInsertedFromNavigation { get; set; } = new List<ReportRegisterSampleTaken>();

    public virtual ICollection<ReportRegisterSampleTaken> ReportRegisterSampleTakenUpdatedFromNavigation { get; set; } = new List<ReportRegisterSampleTaken>();

    public virtual ICollection<ReportRegisterStatusDetail> ReportRegisterStatusDetailInsertedFromNavigation { get; set; } = new List<ReportRegisterStatusDetail>();

    public virtual ICollection<ReportRegisterStatusDetail> ReportRegisterStatusDetailUpdatedFromNavigation { get; set; } = new List<ReportRegisterStatusDetail>();

    public virtual ICollection<ReportRegisterStatus> ReportRegisterStatusInsertedFromNavigation { get; set; } = new List<ReportRegisterStatus>();

    public virtual ICollection<ReportRegisterStatusType> ReportRegisterStatusType { get; set; } = new List<ReportRegisterStatusType>();

    public virtual ICollection<ReportRegisterStatus> ReportRegisterStatusUpdatedFromNavigation { get; set; } = new List<ReportRegisterStatus>();

    public virtual ICollection<ReportRegisterSurvey> ReportRegisterSurveyInsertedFromNavigation { get; set; } = new List<ReportRegisterSurvey>();

    public virtual ICollection<ReportRegisterSurvey> ReportRegisterSurveyUpdatedFromNavigation { get; set; } = new List<ReportRegisterSurvey>();

    public virtual ICollection<ReportRegisterTherapy> ReportRegisterTherapyInsertedFromNavigation { get; set; } = new List<ReportRegisterTherapy>();

    public virtual ICollection<ReportRegisterTherapy> ReportRegisterTherapyUpdatedFromNavigation { get; set; } = new List<ReportRegisterTherapy>();

    public virtual ICollection<ReportRegisterTrackingStatus> ReportRegisterTrackingStatus { get; set; } = new List<ReportRegisterTrackingStatus>();

    public virtual ICollection<ReportRegisterTrackingStatusStaff> ReportRegisterTrackingStatusStaffInsertedFromNavigation { get; set; } = new List<ReportRegisterTrackingStatusStaff>();

    public virtual ICollection<ReportRegisterTrackingStatusStaff> ReportRegisterTrackingStatusStaffUser { get; set; } = new List<ReportRegisterTrackingStatusStaff>();

    public virtual ICollection<ReportRegister> ReportRegisterUpdatedFromNavigation { get; set; } = new List<ReportRegister>();

    public virtual ICollection<ReportingTimeType> ReportingTimeTypeInsertedFromNavigation { get; set; } = new List<ReportingTimeType>();

    public virtual ICollection<ReportingTimeType> ReportingTimeTypeUpdatedFromNavigation { get; set; } = new List<ReportingTimeType>();

    public virtual ICollection<SampleTakenType> SampleTakenTypeInsertedFromNavigation { get; set; } = new List<SampleTakenType>();

    public virtual ICollection<SampleTakenType> SampleTakenTypeUpdatedFromNavigation { get; set; } = new List<SampleTakenType>();

    public virtual ICollection<SurveyModel> SurveyModelInsertedFromNavigation { get; set; } = new List<SurveyModel>();

    public virtual ICollection<SurveyModelTemp> SurveyModelTempInsertedFromNavigation { get; set; } = new List<SurveyModelTemp>();

    public virtual ICollection<SurveyModelTemp> SurveyModelTempUpdatedFromNavigation { get; set; } = new List<SurveyModelTemp>();

    public virtual ICollection<SurveyModel> SurveyModelUpdatedFromNavigation { get; set; } = new List<SurveyModel>();

    public virtual ICollection<SyndromeType> SyndromeTypeInsertedFromNavigation { get; set; } = new List<SyndromeType>();

    public virtual ICollection<SyndromeType> SyndromeTypeUpdatedFromNavigation { get; set; } = new List<SyndromeType>();

    public virtual ICollection<AspNetRoles> Role { get; set; } = new List<AspNetRoles>();
}
