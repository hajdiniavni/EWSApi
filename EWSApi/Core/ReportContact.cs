using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportContact
{
    public int ReportContactId { get; set; }

    public int ReportId { get; set; }

    public string? PersonalNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int GenderId { get; set; }

    public string Relationship { get; set; } = null!;

    public int? MunicipalityId { get; set; }

    public int? SettlementId { get; set; }

    public string? Address { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
