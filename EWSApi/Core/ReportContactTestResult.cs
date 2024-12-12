using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportContactTestResult
{
    public int ReportContactTestResultId { get; set; }

    public string? ProtocolNumber { get; set; }

    public int ReportContactTestId { get; set; }

    public int HealthInstitutionId { get; set; }

    public string HealthInstitutionName { get; set; } = null!;

    public string HealthInstitutionAddress { get; set; } = null!;

    public bool IsPositive { get; set; }

    public string ResultSchema { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime ResultDate { get; set; }

    public DateTime InsertedDate { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public virtual HealthInstitution HealthInstitution { get; set; } = null!;

    public virtual ReportContactTest ReportContactTest { get; set; } = null!;
}
