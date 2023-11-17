using System;
using System.Collections.Generic;

namespace EWSApi.Models.DiseaseInfection;

public partial class DiseaseInfectionVM
{
   

    public int? DiseaseInfectionTypeId { get; set; }

    public string DiseaseCode { get; set; } = null!;

    public bool? DataEncrypted { get; set; }

    public bool? IsTransmissionDisease { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public int ReportingTimeTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

   
}
