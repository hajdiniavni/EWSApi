using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Examination
{
    public int ExaminationId { get; set; }

    public string ExaminationName { get; set; } = null!;

    public string ExaminationCode { get; set; } = null!;

    public bool IsEpidemic { get; set; }

    public byte ResultTime { get; set; }

    public byte LocalPrice { get; set; }

    public byte ForeignPrice { get; set; }

    public byte Active { get; set; }

    public bool IsDynamic { get; set; }

    public virtual ICollection<ReportRegisterTest> ReportRegisterTest { get; set; } = new List<ReportRegisterTest>();
}
