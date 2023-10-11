using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Log
{
    public long LogId { get; set; }

    public string? UserId { get; set; }

    public string Ip { get; set; } = null!;

    public string HostName { get; set; } = null!;

    public string Controller { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? ActionDescription { get; set; }

    public string? HttpMethod { get; set; }

    public string? Url { get; set; }

    public string? Developer { get; set; }

    public string? DescriptionTitle { get; set; }

    public string? Description { get; set; }

    public bool BError { get; set; }

    public string? FormContent { get; set; }

    public string? Exception { get; set; }

    public int? Status { get; set; }

    public DateTime InsertedDate { get; set; }

    public virtual AspNetUsers? User { get; set; }
}
