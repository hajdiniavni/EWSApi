using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegisterSurvey
{
    public int ReportRegisterSurveyId { get; set; }

    public int ReportRegisterId { get; set; }

    public string Schema { get; set; } = null!;

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
