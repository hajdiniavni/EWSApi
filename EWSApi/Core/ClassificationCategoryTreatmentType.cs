using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ClassificationCategoryTreatmentType
{
    public int ClassificationCategoryTreatmentTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportTreatment> ReportTreatment { get; set; } = new List<ReportTreatment>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
