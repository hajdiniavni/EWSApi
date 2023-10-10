using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegisterTest
{
    public int ReportRegisterTestId { get; set; }

    public int ReportRegisterId { get; set; }

    public int ExaminationId { get; set; }

    public string TestTypeName { get; set; } = null!;

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public virtual Examination Examination { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual ICollection<ReportRegisterTestResult> ReportRegisterTestResult { get; set; } = new List<ReportRegisterTestResult>();
}
