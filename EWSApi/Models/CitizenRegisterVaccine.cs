using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class CitizenRegisterVaccine
{
    public int CitizenRegisterVaccineId { get; set; }

    public int CitizenRegisterId { get; set; }

    public string VaccineCode { get; set; } = null!;

    public string VaccineType { get; set; } = null!;

    public DateTime VaccineDate { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public virtual CitizenRegister CitizenRegister { get; set; } = null!;
}
