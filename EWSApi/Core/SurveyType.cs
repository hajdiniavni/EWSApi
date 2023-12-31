﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SurveyType
{
    public int SurveyTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool? Active { get; set; }

    public string? InsertedFrom { get; set; }

    public DateTime? InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<SurveyModel> SurveyModel { get; set; } = new List<SurveyModel>();

    public virtual ICollection<SurveyModelTemp> SurveyModelTemp { get; set; } = new List<SurveyModelTemp>();
}
