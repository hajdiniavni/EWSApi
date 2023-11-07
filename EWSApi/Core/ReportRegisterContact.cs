using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class ReportRegisterContact
{
    public int ReportRegisterContactId { get; set; }

    public int ReportRegisterId { get; set; }

    public int ContactTypeId { get; set; }

    public int? ReportRegisterContactPersonId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public int GenderId { get; set; }

    public int ProfessionId { get; set; }

    public string Relationship { get; set; } = null!;

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual ProfessionType Profession { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;

    public virtual ICollection<ReportRegisterContactSurvey> ReportRegisterContactSurvey { get; set; } = new List<ReportRegisterContactSurvey>();

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
