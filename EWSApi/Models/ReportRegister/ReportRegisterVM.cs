using System;
using System.Collections.Generic;

namespace EWSApi.Models.ReportRegister;

public partial class ReportRegisterVM
{
    /// <summary>
    /// HealthInstitution
    /// </summary>
    public string? HealthInstitutionIdentificationNumber { get; set; }

    public string? HealthInstitutionLicenseNumber { get; set; }

    public string? HealthInstitutionName { get; set; }

    public string? HealthInstitutionAddress { get; set; }

    /// <summary>
    /// Citizen
    /// </summary>



    public string PersonalNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? PartnerName { get; set; }

    public string? Gender { get; set; }

    public DateTime Birthdate { get; set; }

    public bool LivingStatus { get; set; }

    public int? MaritalStatusId { get; set; }

    public bool Foreign { get; set; }

    public int CountryId { get; set; }

    public int? MunicipalityId { get; set; }

    public string? Municipality { get; set; }

    public int? SettlementId { get; set; }

    public string? Settlement { get; set; }

    public string Address { get; set; } = null!;

    public string? BirthPlace { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? ConsultingDate { get; set; }

    public int? SyndromeTypeId { get; set; }

    public DateTime? SymptomDate { get; set; }

    public DateTime? SampleTakenDate { get; set; }

    public string? MedicalLicenseNumber { get; set; }
    public string? MedicalPersonalNumber { get; set; }

    public List<ReportRegisterSampleTakenVM> reportRegisterSampleTaken { get; set; } = new List<ReportRegisterSampleTakenVM>();
    public List<CaseClassificationVM> caseClassification { get; set; } = new List<CaseClassificationVM>();
    public List<ReportRegisterStatusVM> reportRegisterStatus { get; set; } = new List<ReportRegisterStatusVM>();
    public List<ReportRegisterTestVM> reportRegisterTest { get; set; } = new List<ReportRegisterTestVM>();
}

/// <summary>
/// Diagonse and Syndrome
/// </summary>
public class CaseClassificationVM
{
   
    public int? CCSyndromeTypeId { get; set; }
    public int CaseClassificationTypeId { get; set; }
    public int DiseaseInfectionId { get; set; }
}


///   <summary>
///  Status
/// </summary>
public class ReportRegisterStatusVM
{
    public int ReportRegisterStatusTypeId { get; set; }
 
}

/// <summary>
/// Sample
/// </summary>
public class ReportRegisterSampleTakenVM
{
    public int SampleTakenTypeId { get; set; }

}


///  <summary>
/// Test
/// </summary>
public class ReportRegisterTestVM
{
    public int ExaminationId { get; set; }
    public string TestTypeName { get; set; } = null!;
}




