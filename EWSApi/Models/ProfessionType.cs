using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ProfessionType
{
    public int ProfessionTypeId { get; set; }

    public string ProfessionTypeSq { get; set; } = null!;

    public string ProfessionTypeEn { get; set; } = null!;

    public string ProfessionTypeSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ReportRegister> ReportRegister { get; set; } = new List<ReportRegister>();

    public virtual ICollection<ReportRegisterContact> ReportRegisterContact { get; set; } = new List<ReportRegisterContact>();
}
