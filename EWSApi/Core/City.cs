﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class City
{
    public int CityId { get; set; }

    public int CountryId { get; set; }

    public int RegionId { get; set; }

    public string NameSq { get; set; } = null!;

    public string? NameEn { get; set; }

    public string? NameSr { get; set; }

    public string? PostalCode { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<HealthInstitution> HealthInstitution { get; set; } = new List<HealthInstitution>();

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<Region> RegionNavigation { get; set; } = new List<Region>();

    public virtual ICollection<Report> Report { get; set; } = new List<Report>();

    public virtual ICollection<Settlement> Settlement { get; set; } = new List<Settlement>();
}
