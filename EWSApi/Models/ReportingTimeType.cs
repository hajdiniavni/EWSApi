using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportingTimeType
{
    public int ReportingTimeTypeId { get; set; }

    public int Day { get; set; }

    public string ReportingTimeSq { get; set; } = null!;

    public string ReportingTimeEn { get; set; } = null!;

    public string ReportingTimeSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<DiseaseInfection> DiseaseInfection { get; set; } = new List<DiseaseInfection>();

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
