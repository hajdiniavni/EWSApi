﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class StatusType
{
    public int StatusTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool? Active { get; set; }

    public string? InsertedFrom { get; set; }

    public DateTime? InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<FaqquestionStatus> FaqquestionStatus { get; set; } = new List<FaqquestionStatus>();

    public virtual ICollection<ReportRegisterTrackingStatus> ReportRegisterTrackingStatus { get; set; } = new List<ReportRegisterTrackingStatus>();

    public virtual ICollection<ReportStatus> ReportStatus { get; set; } = new List<ReportStatus>();
}
