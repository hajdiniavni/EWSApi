using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Faqrate
{
    public int FaqrateId { get; set; }

    public int FaqquestionId { get; set; }

    public int Rate { get; set; }

    public string? Description { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Faqquestion Faqquestion { get; set; } = null!;
}
