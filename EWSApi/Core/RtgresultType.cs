using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class RtgresultType
{
    public int RtgresultTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportTestResult> ReportTestResult { get; set; } = new List<ReportTestResult>();

    public virtual ICollection<ReportTestResultRtg> ReportTestResultRtg { get; set; } = new List<ReportTestResultRtg>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
