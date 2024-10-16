using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Icd101
{
    public int Id { get; set; }

    public string IcdoriginCode { get; set; } = null!;

    public string TitleSq { get; set; } = null!;
}
