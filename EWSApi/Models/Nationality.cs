using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;
}
