using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseInfection
{
    public int DiseaseInfectionId { get; set; }

    public int? DiseaseInfectionTypeId { get; set; }

    public string DiseaseCode { get; set; } = null!;

    public bool? DataEncrypted { get; set; }

    public bool? IsTransmissionDisease { get; set; }

    public int? NumberCaseNotification { get; set; }

    public int? DaysNotification { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public int? ReportingTimeTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<DiseaseInfectionSurvey> DiseaseInfectionSurvey { get; set; } = new List<DiseaseInfectionSurvey>();

    public virtual DiseaseInfectionType? DiseaseInfectionType { get; set; }

    public virtual ICollection<DiseaseNotification> DiseaseNotification { get; set; } = new List<DiseaseNotification>();

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportDiseaseInfection> ReportDiseaseInfection { get; set; } = new List<ReportDiseaseInfection>();

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual ICollection<ReportRegisterConcomitantDisease> ReportRegisterConcomitantDisease { get; set; } = new List<ReportRegisterConcomitantDisease>();

    public virtual ReportingTimeType? ReportingTimeType { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
