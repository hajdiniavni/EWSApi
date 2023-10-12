using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWSApi.Models.HealthInstitution;

public partial class HealthInstitutionVM
{
    public int HealthInstitutionId { get; set; }

    [Required]
    public int HealthInstitutionLevelId { get; set; }

    [Required]
    public string? IdentificationNumber { get; set; }

    [Required]
    public string? LicenceNumber { get; set; }

    [Required]
    public string NameSq { get; set; } = null!;

    [Required]
    public string NameEn { get; set; } = null!;

    [Required]
    public string NameSr { get; set; } = null!;

    [Required]
    public string? ShortNameSq { get; set; }

    [Required]
    public string? ShortNameEn { get; set; }

    [Required]
    public string? ShortNameSr { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    [Range(1, 38)]
    public int MinicipalityId { get; set; }

    [Required]
    public int SettlementId { get; set; }

    [Required]
    public string? Address { get; set; }

    [Required]
    public string Status { get; set; } = null!;

    [Required]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
    public string? EmailAddress { get; set; }

    [Required]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage = "Please enter correct phone number")]
    public string? PhoneNumber { get; set; }

  

    
}
