﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SideEffectType
{
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

    public virtual ICollection<ReportRegimenTreatment> ReportRegimenTreatment { get; set; } = new List<ReportRegimenTreatment>();

    public virtual ICollection<SubSideEffectType> SubSideEffectType { get; set; } = new List<SubSideEffectType>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
