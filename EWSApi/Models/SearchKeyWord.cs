using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class SearchKeyWord
{
    public int SearchIndicatorsId { get; set; }

    public string SearchIndicators { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
