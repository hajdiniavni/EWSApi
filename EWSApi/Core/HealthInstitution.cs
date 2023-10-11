using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class HealthInstitution
{
    public int HealthInstitutionId { get; set; }

    public int HealthInstitutionLevelId { get; set; }

    public string? IdentificationNumber { get; set; }

    public string? LicenceNumber { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public string? ShortNameSq { get; set; }

    public string? ShortNameEn { get; set; }

    public string? ShortNameSr { get; set; }

    public string? Description { get; set; }

    public int MinicipalityId { get; set; }

    public int SettlementId { get; set; }

    public string? Address { get; set; }

    public string Status { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual HealthInstitutionLevel HealthInstitutionLevel { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual City Minicipality { get; set; } = null!;

    public virtual ICollection<ReportRegister> ReportRegister { get; set; } = new List<ReportRegister>();

    public virtual ICollection<ReportRegisterReference> ReportRegisterReferenceHealthInstitutionFrom { get; set; } = new List<ReportRegisterReference>();

    public virtual ICollection<ReportRegisterReference> ReportRegisterReferenceHealthInstitutionTo { get; set; } = new List<ReportRegisterReference>();

    public virtual ICollection<ReportRegisterTestResult> ReportRegisterTestResult { get; set; } = new List<ReportRegisterTestResult>();

    public virtual Settlement Settlement { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
