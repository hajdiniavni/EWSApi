using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterReference
{
    public int ReportRegisterReferenceId { get; set; }

    public int ReportRegisterStatusId { get; set; }

    public int HealthInstitutionFromId { get; set; }

    public string HealthInstitutionFromName { get; set; } = null!;

    public string HealthInstitutionFromAddress { get; set; } = null!;

    public int? HealthInstitutionToId { get; set; }

    public string HealthInstitutionToName { get; set; } = null!;

    public string HealthInstitutionToAddress { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual HealthInstitution HealthInstitutionFrom { get; set; } = null!;

    public virtual HealthInstitution? HealthInstitutionTo { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegisterStatus ReportRegisterStatus { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
