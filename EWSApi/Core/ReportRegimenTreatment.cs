using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegimenTreatment
{
    public int ReportRegimenTreatmentId { get; set; }

    public int ReportId { get; set; }

    public int HealthInstitutionId { get; set; }

    public int RegimenTreatmentTypeId { get; set; }

    public int? SideEffectTypeId { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual HealthInstitution HealthInstitution { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual RegimenTreatmentType RegimenTreatmentType { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual ICollection<ReportRegimenTreatmentSubSideEffect> ReportRegimenTreatmentSubSideEffect { get; set; } = new List<ReportRegimenTreatmentSubSideEffect>();

    public virtual SideEffectType? SideEffectType { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
