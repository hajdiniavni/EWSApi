using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SubSideEffectType
{
    public int SubSideEffectTypeId { get; set; }

    public int SideEffectTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportRegimenTreatmentSubSideEffect> ReportRegimenTreatmentSubSideEffect { get; set; } = new List<ReportRegimenTreatmentSubSideEffect>();

    public virtual SideEffectType SideEffectType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
