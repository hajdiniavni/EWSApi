using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterTrackingStatusStaff
{
    public int ReportRegisterTrackingStatusStaffId { get; set; }

    public int? ReportRegisterTrackingStatusId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Active { get; set; }

    public string? Description { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegisterTrackingStatus? ReportRegisterTrackingStatus { get; set; }

    public virtual AspNetUsers User { get; set; } = null!;
}
