using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class ReportRegisterCaseClassification
{
    public int ReportRegisterCaseClassificationId { get; set; }

    public int ReportRegisterId { get; set; }

    public int? SyndromeTypeId { get; set; }

    public int CaseClassificationTypeId { get; set; }

    /// <summary>
    /// Diagnose
    /// </summary>
    public int DiseaseInfectionId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CaseClassificationType CaseClassificationType { get; set; } = null!;

    public virtual DiseaseInfection DiseaseInfection { get; set; } = null!;

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual SyndromeType? SyndromeType { get; set; }

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
