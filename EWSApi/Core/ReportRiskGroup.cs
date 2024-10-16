using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRiskGroup
{
    public int ReportRiskGroupId { get; set; }

    public int ReportId { get; set; }

    public int RiskGroupTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual RiskGroupType RiskGroupType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
