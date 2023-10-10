using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class SearchSourceSite
{
    public int SearchSourceSiteId { get; set; }

    public string SearchSourceSite1 { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
