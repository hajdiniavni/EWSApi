using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class AgeGroup
{
    public int AgeGroupId { get; set; }

    public string AgeGroup1 { get; set; } = null!;

    public int From { get; set; }

    public int To { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
