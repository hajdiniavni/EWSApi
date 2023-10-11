using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Examination
{
    public int ExaminationId { get; set; }

    public string ExaminationName { get; set; } = null!;

    public string ExaminationCode { get; set; } = null!;

    public bool IsEpidemic { get; set; }

    public int ResultTime { get; set; }

    public int LocalPrice { get; set; }

    public int ForeignPrice { get; set; }

    public bool Active { get; set; }

    public bool IsDynamic { get; set; }

    public string? InsertedFrom { get; set; }

    public DateTime? InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ReportRegisterTest> ReportRegisterTest { get; set; } = new List<ReportRegisterTest>();
}
