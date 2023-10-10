using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Settlement
{
    public int SettlementId { get; set; }

    public int CityId { get; set; }

    public string NameSq { get; set; } = null!;

    public string? NameEn { get; set; }

    public string? NameSr { get; set; }

    public string? NameTr { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<HealthInstitution> HealthInstitution { get; set; } = new List<HealthInstitution>();
}
