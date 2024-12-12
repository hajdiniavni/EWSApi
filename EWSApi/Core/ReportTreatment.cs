using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportTreatment
{
    public int ReportTreatmentId { get; set; }

    public int ReportId { get; set; }

    public int ClassificationCategoryTypeId { get; set; }

    public int? ClassificationCategoryTreatmentTypeId { get; set; }

    public bool Active { get; set; }

    public string? Description { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ClassificationCategoryTreatmentType? ClassificationCategoryTreatmentType { get; set; }

    public virtual ClassificationCategoryType ClassificationCategoryType { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
