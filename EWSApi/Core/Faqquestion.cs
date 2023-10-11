using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Faqquestion
{
    public int FaqquestionId { get; set; }

    public int? FaqcategoryId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserSurname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Question { get; set; } = null!;

    public string? Answer { get; set; }

    public int? Position { get; set; }

    public bool Visible { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Faqcategory? Faqcategory { get; set; }

    public virtual ICollection<FaqquestionStatus> FaqquestionStatus { get; set; } = new List<FaqquestionStatus>();

    public virtual ICollection<Faqrate> Faqrate { get; set; } = new List<Faqrate>();
}
