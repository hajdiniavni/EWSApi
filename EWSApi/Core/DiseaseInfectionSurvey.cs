using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseInfectionSurvey
{
    public int DiseaseInfectionSurveyId { get; set; }

    public int DiseaseInfectionId { get; set; }

    public int SurveyModelId { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual DiseaseInfection DiseaseInfection { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual SurveyModel SurveyModel { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
