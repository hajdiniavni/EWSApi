using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Report
{
    public int ReportId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public int? MedicalStaffId { get; set; }

    public int RegionId { get; set; }

    public int HealthInstitutionId { get; set; }

    public int? QuarterId { get; set; }

    public int CitizenRegisterId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string Birthdate { get; set; } = null!;

    public int GenderId { get; set; }

    public int NationalityId { get; set; }

    public int? Length { get; set; }

    public decimal? Weight { get; set; }

    public int? MunicipalityId { get; set; }

    public int? SettlementId { get; set; }

    public string Address { get; set; } = null!;

    public int? ReferenceTypeId { get; set; }

    public int? ReferenceHealthInstitutionId { get; set; }

    public string? ContactPersonName { get; set; }

    public string? ContactPersonAddress { get; set; }

    public string? ContactPersonPhoneNumber { get; set; }

    public DateTime? TreatmentStartDate { get; set; }

    public int? CaseClassificationTypeId { get; set; }

    public int? DiseaseClassificationTypeId { get; set; }

    public int? ExtraPulmonarTypeId { get; set; }

    public int? BcgtypeId { get; set; }

    public int? OrdinaryDoctorId { get; set; }

    public int? Year { get; set; }

    public int? TreatmentResultTypeId { get; set; }

    public string? Drugs { get; set; }

    public int? ContactsNumber { get; set; }

    public int? ChemicalExaminations { get; set; }

    public int? Rtgnumber { get; set; }

    public int? MicrobiologyNumber { get; set; }

    public int? Ppdnumber { get; set; }

    public int? HealthyNumber { get; set; }

    public string? PatientNumber { get; set; }

    public int? Iltbnumber { get; set; }

    public int? IltbchemoNumber { get; set; }

    public int? IltbchemoCompleteNumber { get; set; }

    public string? InsertedFrom { get; set; }

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Bcgtype? Bcgtype { get; set; }

    public virtual CaseClassificationType1? CaseClassificationType { get; set; }

    public virtual CitizenRegister CitizenRegister { get; set; } = null!;

    public virtual DiseaseClassificationType? DiseaseClassificationType { get; set; }

    public virtual ExtraPulmonarType? ExtraPulmonarType { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual MedicalStaff? MedicalStaff { get; set; }

    public virtual City? Municipality { get; set; }

    public virtual Nationality Nationality { get; set; } = null!;

    public virtual Quarter? Quarter { get; set; }

    public virtual HealthInstitution? ReferenceHealthInstitution { get; set; }

    public virtual ReferenceType? ReferenceType { get; set; }

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<ReportContact> ReportContact { get; set; } = new List<ReportContact>();

    public virtual ICollection<ReportDiseaseInfection> ReportDiseaseInfection { get; set; } = new List<ReportDiseaseInfection>();

    public virtual ICollection<ReportHospitalTreatment> ReportHospitalTreatment { get; set; } = new List<ReportHospitalTreatment>();

    public virtual ICollection<ReportRegimenTreatment> ReportRegimenTreatment { get; set; } = new List<ReportRegimenTreatment>();

    public virtual ICollection<ReportRiskFactor> ReportRiskFactor { get; set; } = new List<ReportRiskFactor>();

    public virtual ICollection<ReportRiskGroup> ReportRiskGroup { get; set; } = new List<ReportRiskGroup>();

    public virtual ICollection<ReportStatus> ReportStatus { get; set; } = new List<ReportStatus>();

    public virtual ICollection<ReportTest> ReportTest { get; set; } = new List<ReportTest>();

    public virtual ICollection<ReportTreatment> ReportTreatment { get; set; } = new List<ReportTreatment>();

    public virtual Settlement? Settlement { get; set; }

    public virtual TreatmentResultType? TreatmentResultType { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
