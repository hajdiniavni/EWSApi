using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class SearchResults
{
    public int SearchResultId { get; set; }

    public string Url { get; set; } = null!;

    public string SearchIndicators { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublishDate { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }
}
