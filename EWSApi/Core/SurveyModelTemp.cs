using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SurveyModelTemp
{
    public int SurveyModelTempId { get; set; }

    public int SurveyTypeId { get; set; }

    public int? RowId { get; set; }

    public string Schema { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual SurveyType SurveyType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
