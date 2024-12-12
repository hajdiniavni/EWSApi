using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportContactTest
{
    public int ReportContactTestId { get; set; }

    public int ReportContactId { get; set; }

    public int ExaminationId { get; set; }

    public string TestTypeName { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Examination Examination { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportContactTestResult> ReportContactTestResult { get; set; } = new List<ReportContactTestResult>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
