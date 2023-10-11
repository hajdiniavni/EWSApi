using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SearchIndicators
{
    public int SearchKeyWordId { get; set; }

    public string SearchKeyWord { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
