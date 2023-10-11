using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Gender
{
    public int GenderId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;
}
