using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class MedicalStaff
{
    public int MedicalStaffId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string LicenceNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Specialization { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Report> Report { get; set; } = new List<Report>();

    public virtual ICollection<ReportRegisterStatus> ReportRegisterStatus { get; set; } = new List<ReportRegisterStatus>();

    public virtual ICollection<ReportRegisterTherapy> ReportRegisterTherapyMedicalStaff { get; set; } = new List<ReportRegisterTherapy>();

    public virtual ICollection<ReportRegisterTherapy> ReportRegisterTherapyUpdatedByMedicalStaff { get; set; } = new List<ReportRegisterTherapy>();

    public virtual ICollection<ReportStatus> ReportStatus { get; set; } = new List<ReportStatus>();
}
