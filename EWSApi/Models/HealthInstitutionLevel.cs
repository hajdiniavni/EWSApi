using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class HealthInstitutionLevel
{
    public int HealthInstitutionLevelId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<HealthInstitution> HealthInstitution { get; set; } = new List<HealthInstitution>();

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
