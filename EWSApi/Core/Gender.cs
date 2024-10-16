using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Gender
{
    public int GenderId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public virtual ICollection<Report> Report { get; set; } = new List<Report>();

    public virtual ICollection<ReportRegister> ReportRegister { get; set; } = new List<ReportRegister>();
}
