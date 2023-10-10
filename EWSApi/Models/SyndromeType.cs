using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class SyndromeType
{
    public int SyndromeTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public string? ShortNameSq { get; set; }

    public string? ShortNameEn { get; set; }

    public string? ShortNameSr { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportRegister> ReportRegister { get; set; } = new List<ReportRegister>();

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
