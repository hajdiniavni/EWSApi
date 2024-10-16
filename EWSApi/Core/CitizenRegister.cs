using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class CitizenRegister
{
    public int CitizenRegisterId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? PartnerName { get; set; }

    public int GenderId { get; set; }

    public string Birthdate { get; set; } = null!;

    public bool LivingStatus { get; set; }

    public int? MaritalStatusId { get; set; }

    public bool Foreign { get; set; }

    /// <summary>
    /// The default value is 1 - Kosova
    /// </summary>
    public int CountryId { get; set; }

    public int? MunicipalityId { get; set; }

    public string? Municipality { get; set; }

    public int? SettlementId { get; set; }

    public string? Settlement { get; set; }

    public string Address { get; set; } = null!;

    public string? BirthPlace { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? UpdatedCitizen { get; set; }

    public virtual ICollection<CitizenRegisterVaccine> CitizenRegisterVaccine { get; set; } = new List<CitizenRegisterVaccine>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Report> Report { get; set; } = new List<Report>();

    public virtual ICollection<ReportRegister> ReportRegister { get; set; } = new List<ReportRegister>();
}
