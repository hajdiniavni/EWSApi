using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterTestResult
{
    public int ReportRegisterTestResultId { get; set; }

    public int ReportRegisterTestId { get; set; }

    public int HealthInstitutionId { get; set; }

    public string HealthInstitutionName { get; set; } = null!;

    public string HealthInstitutionAddress { get; set; } = null!;

    public bool IsPositive { get; set; }

    public string ResultSchema { get; set; } = null!;

    public DateTime ResultDate { get; set; }

    public DateTime InsertedDate { get; set; }

    public string UserName { get; set; } = null!;

    public virtual HealthInstitution HealthInstitution { get; set; } = null!;

    public virtual ReportRegisterTest ReportRegisterTest { get; set; } = null!;
}
