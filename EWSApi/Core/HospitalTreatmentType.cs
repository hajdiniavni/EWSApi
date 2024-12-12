using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class HospitalTreatmentType
{
    public int HospitalTreatmentTypeId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportHospitalTreatment> ReportHospitalTreatment { get; set; } = new List<ReportHospitalTreatment>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
