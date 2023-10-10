using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Notification
{
    public long NotificationId { get; set; }

    public byte Type { get; set; }

    public string Title { get; set; } = null!;

    public string? Details { get; set; }

    public string? Url { get; set; }

    public string Receiver { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public bool Read { get; set; }

    public bool Deleted { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }
}
