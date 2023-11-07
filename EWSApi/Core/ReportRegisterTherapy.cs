using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterTherapy
{
    public int ReportRegisterTherapyId { get; set; }

    public int ReportRegisterId { get; set; }

    public int MedicalStaffId { get; set; }

    public string Therapy { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public int? UpdatedByMedicalStaffId { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual MedicalStaff MedicalStaff { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual MedicalStaff? UpdatedByMedicalStaff { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
