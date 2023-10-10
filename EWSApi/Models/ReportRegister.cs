using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegister
{
    public int ReportRegisterId { get; set; }

    public string UniqueNumber { get; set; } = null!;

    public int HealthInstitutionId { get; set; }

    public string? HealthInstitutionName { get; set; }

    public string? HealthInstitutionAddress { get; set; }

    public int CitizenRegisterId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? PartnerName { get; set; }

    public DateTime Birthdate { get; set; }

    public int GenderId { get; set; }

    public string Address { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public int? ProfessionTypeId { get; set; }

    public DateTime? ConsultingDate { get; set; }

    public int? SyndromeTypeId { get; set; }

    public DateTime? SymptomDate { get; set; }

    public DateTime? SampleTakenDate { get; set; }

    public bool? LaboratoryConfirmation { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CitizenRegister CitizenRegister { get; set; } = null!;

    public virtual HealthInstitution HealthInstitution { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ProfessionType? ProfessionType { get; set; }

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual ICollection<ReportRegisterContact> ReportRegisterContact { get; set; } = new List<ReportRegisterContact>();

    public virtual ICollection<ReportRegisterSampleTaken> ReportRegisterSampleTaken { get; set; } = new List<ReportRegisterSampleTaken>();

    public virtual ICollection<ReportRegisterStatus> ReportRegisterStatus { get; set; } = new List<ReportRegisterStatus>();

    public virtual ICollection<ReportRegisterSurvey> ReportRegisterSurvey { get; set; } = new List<ReportRegisterSurvey>();

    public virtual ICollection<ReportRegisterTest> ReportRegisterTest { get; set; } = new List<ReportRegisterTest>();

    public virtual SyndromeType? SyndromeType { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
