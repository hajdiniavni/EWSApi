using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SampleTakenType
{
    public int SampleTakenTypeId { get; set; }

    public string SampleTakenTypeSq { get; set; } = null!;

    public string SampleTakenTypeEn { get; set; } = null!;

    public string SampleTakenTypeSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportRegisterSampleTaken> ReportRegisterSampleTaken { get; set; } = new List<ReportRegisterSampleTaken>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
