using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseInfection
{
    public int DiseaseInfectionId { get; set; }

    public int? DiseaseInfectionTypeId { get; set; }

    public string DiseaseCode { get; set; } = null!;

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public int ReportingTimeTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual DiseaseInfectionType? DiseaseInfectionType { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ICollection<ReportRegisterCaseClassification> ReportRegisterCaseClassification { get; set; } = new List<ReportRegisterCaseClassification>();

    public virtual ReportingTimeType ReportingTimeType { get; set; } = null!;

    public virtual ICollection<SurveyType> SurveyType { get; set; } = new List<SurveyType>();

    public virtual ICollection<SurveyTypeTemp> SurveyTypeTemp { get; set; } = new List<SurveyTypeTemp>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
