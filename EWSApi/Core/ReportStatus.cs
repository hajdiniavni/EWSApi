using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportStatus
{
    public int ReportStatusId { get; set; }

    public int ReportId { get; set; }

    public int ReportStatusTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public int? MedicalStaffId { get; set; }

    public string? NurseId { get; set; }

    public DateTime? EndDateOfTreatment { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual MedicalStaff? MedicalStaff { get; set; }

    public virtual AspNetUsers? Nurse { get; set; }

    public virtual Report Report { get; set; } = null!;

    public virtual StatusType ReportStatusType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
