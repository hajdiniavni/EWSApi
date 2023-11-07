using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterTrackingStatus
{
    public int ReportRegisterTrackingStatusId { get; set; }

    public int ReportRegisterId { get; set; }

    public int StatusTypeId { get; set; }

    public bool Active { get; set; }

    public string? Description { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual ICollection<ReportRegisterTrackingStatusStaff> ReportRegisterTrackingStatusStaff { get; set; } = new List<ReportRegisterTrackingStatusStaff>();

    public virtual StatusType StatusType { get; set; } = null!;
}
