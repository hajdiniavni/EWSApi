using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterStatusDetail
{
    public int ReportRegisterStatusDetailId { get; set; }

    public int ReportRegisterStatusId { get; set; }

    public string? Floor { get; set; }

    public string? Department { get; set; }

    public string? RoomNumber { get; set; }

    public string? BedNumber { get; set; }

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
