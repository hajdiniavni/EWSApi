﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Country
{
    public int CountryId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public string? Code { get; set; }

    public string? FlagPath { get; set; }

    public string? Prefix { get; set; }

    public virtual ICollection<CitizenRegister> CitizenRegister { get; set; } = new List<CitizenRegister>();

    public virtual ICollection<City> City { get; set; } = new List<City>();
}
