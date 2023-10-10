using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegisterStatusDetail
{
    public int ReportRegisterStatusDetailId { get; set; }

    public int ReportRegisterStatusId { get; set; }

    public string Floor { get; set; } = null!;

    public string RoomNumber { get; set; } = null!;

    public string BedNumber { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string? Therapy { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegisterStatus ReportRegisterStatus { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
