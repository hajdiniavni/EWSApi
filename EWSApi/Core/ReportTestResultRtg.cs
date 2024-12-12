using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportTestResultRtg
{
    public int ReportTestResultRtgid { get; set; }

    public int RtgresultTypeId { get; set; }

    public virtual RtgresultType RtgresultType { get; set; } = null!;
}
