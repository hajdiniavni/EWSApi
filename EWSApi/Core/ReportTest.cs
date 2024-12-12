using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportTest
{
    public int ReportTestId { get; set; }

    public int ReportId { get; set; }

    public int ExaminationId { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public virtual Examination Examination { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual ICollection<ReportTestResult> ReportTestResult { get; set; } = new List<ReportTestResult>();
}
