﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterTestResult
{
    public int ReportRegisterTestResultId { get; set; }

    public int ReportRegisterTestId { get; set; }

    public int? HealthInstitutionId { get; set; }

    public string HealthInstitutionCode { get; set; } = null!;

    public string HealthInstitutionName { get; set; } = null!;

    public string HealthInstitutionAddress { get; set; } = null!;

    public bool IsPositive { get; set; }

    public string ResultSchema { get; set; } = null!;

    public string TestCode { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime ResultDate { get; set; }

    public DateTime InsertedDate { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public virtual ReportRegisterTest ReportRegisterTest { get; set; } = null!;
}
