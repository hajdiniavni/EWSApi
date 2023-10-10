using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegisterStatus
{
    public int ReportRegisterStatusId { get; set; }

    public int ReportRegisterId { get; set; }

    public int ReportRegisterStatusTypeId { get; set; }

    public string? Description { get; set; }

    public int? MedicalStaffId { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual MedicalStaff? MedicalStaff { get; set; }

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual ICollection<ReportRegisterReference> ReportRegisterReference { get; set; } = new List<ReportRegisterReference>();

    public virtual ICollection<ReportRegisterStatusDetail> ReportRegisterStatusDetail { get; set; } = new List<ReportRegisterStatusDetail>();

    public virtual ReportRegisterStatusType ReportRegisterStatusType { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
