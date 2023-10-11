using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterContactSurvey
{
    public int ReportRegisterContactSurveyId { get; set; }

    public int ReportRegisterContactId { get; set; }

    public string Schema { get; set; } = null!;

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegisterContact ReportRegisterContact { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
