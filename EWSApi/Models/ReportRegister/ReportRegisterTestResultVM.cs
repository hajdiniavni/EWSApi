using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWSApi.Models.ReportRegister;

public partial class ReportRegisterTestResultVM
{

    [Required(ErrorMessage = "Mungesë informacioni për fushën ReportRegisterTestId")]
    public int ReportRegisterTestId { get; set; }

    [Required(ErrorMessage = "Mungesë informacioni për fushën HealthInstitutionIdentificationNumber")]
    public string HealthInstitutionCode { get; set; }

    //public string? HealthInstitutionLicenseNumber { get; set; }
    [Required(ErrorMessage = "Mungesë informacioni për fushën HealthInstitutionName")]
    public string HealthInstitutionName { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën HealthInstitutionAddress")]
    public string HealthInstitutionAddress { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën IsPositive")]
    public bool IsPositive { get; set; }

    [Required(ErrorMessage = "Mungesë informacioni për fushën ResultSchema")]
    public string ResultSchema { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën TestCode")]
    public string TestCode { get; set; } = null!;

    [Required(ErrorMessage = "Mungesë informacioni për fushën ResultDate")]
    public DateTime ResultDate { get; set; }

    [Required(ErrorMessage = "Mungesë informacioni për fushën Username")]
    public string Username { get; set; }


}
