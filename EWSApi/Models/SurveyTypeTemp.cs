using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class SurveyTypeTemp
{
    public int SurveyTypeTempId { get; set; }

    public int DiseaseInfectionId { get; set; }

    public string Schema { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual DiseaseInfection DiseaseInfection { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
