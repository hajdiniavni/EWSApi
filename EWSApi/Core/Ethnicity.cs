using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Ethnicity
{
    public int EthnicityId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }
}
