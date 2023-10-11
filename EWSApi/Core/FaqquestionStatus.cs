using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class FaqquestionStatus
{
    public int FaqquestionStatusId { get; set; }

    public int FaqquestionId { get; set; }

    public int StatusTypeId { get; set; }

    public string? Description { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Faqquestion Faqquestion { get; set; } = null!;

    public virtual StatusType StatusType { get; set; } = null!;
}
