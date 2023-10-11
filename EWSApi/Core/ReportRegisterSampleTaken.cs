using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterSampleTaken
{
    public int ReportRegisterSampleTakenId { get; set; }

    public int ReportRegisterId { get; set; }

    public int SampleTakenTypeId { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual SampleTakenType SampleTakenType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
