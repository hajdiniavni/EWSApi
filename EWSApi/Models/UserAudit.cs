using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class UserAudit
{
    public long UserAuditId { get; set; }

    public string? UserId { get; set; }

    public byte ActionType { get; set; }

    public string ActionSq { get; set; } = null!;

    public string ActionEn { get; set; } = null!;

    public string ActionSr { get; set; } = null!;

    public DateTime InsertedDate { get; set; }
}
