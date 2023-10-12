using Azure.Identity;
using System;
using System.Collections.Generic;

namespace EWSApi.Models.ReportRegister;

public partial class ReportRegisterTestResultVM
{
    

    public int ReportRegisterTestId { get; set; }

     public string? HealthInstitutionIdentificationNumber { get; set; }

    public string? HealthInstitutionLicenseNumber { get; set; }

    public string HealthInstitutionName { get; set; } = null!;

    public string HealthInstitutionAddress { get; set; } = null!;

    public bool IsPositive { get; set; }

    public string ResultSchema { get; set; } = null!;

    public DateTime ResultDate { get; set; }

    public string Username { get; set; }


}
