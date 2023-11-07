using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Region
{
    public int RegionId { get; set; }

    public int CityId { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<City> City { get; set; } = new List<City>();

    public virtual City CityNavigation { get; set; } = null!;
}
