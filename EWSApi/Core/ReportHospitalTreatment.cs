using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportHospitalTreatment
{
    public int ReportHospitalTreatmentId { get; set; }

    public int ReportId { get; set; }

    public int HospitalTreatmentTypeId { get; set; }

    public DateTime From { get; set; }

    public DateTime? To { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual HospitalTreatmentType HospitalTreatmentType { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
