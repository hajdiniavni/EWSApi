using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegimenTreatmentSubSideEffect
{
    public int ReportSideEffectId { get; set; }

    public int ReportRegimenTreatmentId { get; set; }

    public int SubSideEffectTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime? SideEffectDate { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegimenTreatment ReportRegimenTreatment { get; set; } = null!;

    public virtual SubSideEffectType SubSideEffectType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
