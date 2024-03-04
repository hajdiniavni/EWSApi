using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWSApi.Models.ReportRegister;

public partial class ReportRegisterVM
{
    /// <summary>
    /// HealthInstitution
    /// </summary>
    public string? HealthInstitutionIdentificationNumber { get; set; }

    public string? HealthInstitutionLicenseNumber { get; set; }

    public string? HealthInstitutionName { get; set; }

    public int? HealthInstitutionMunicipalityID { get; set; }

    public string? HealthInstitutionAddress { get; set; }

    /// <summary>
    /// Citizen
    /// </summary>


    [Required(ErrorMessage = "Mungesë informacioni për fushën PersonalNumber")]
    [MaxLength(10, ErrorMessage = "Numri personal duhet ti përmbaj 10 numra!")]
    [MinLength(10, ErrorMessage = "Numri personal duhet ti përmbaj 10 numra!")]
    public string PersonalNumber { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën Firstname")]
    public string Firstname { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën Lastname")]
    public string Lastname { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? PartnerName { get; set; }

    [StringLength(1, MinimumLength = 1, ErrorMessage = "Vlera në fushën gender duhet të jetë M ose F")]
    public string? Gender { get; set; }

    //[Required(ErrorMessage = "Birthdate is required.")]
    //[Display(Name = "Birthdate")]
    //[RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "Datelindja duhet te jete vetem ne formatin 'yyyy-MM-dd'.")]
    public string? Birthdate { get; set; }

    [Required(ErrorMessage = "Mungesë informacioni për fushën LivingStatus")]
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

    public int SuspectedPlaceTypeID { get; set; }

    public string? SuspectedPlace { get; set; }

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

    public string? HealthInstitutionNameTo { get; set; }

    public int? HealthInstitutionMunicipalityIDTo { get; set; }

    public string? HealthInstitutionAddressTo { get; set; }

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




