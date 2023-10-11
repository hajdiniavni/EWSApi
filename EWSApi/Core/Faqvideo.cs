using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Faqvideo
{
    public int FaqvideoId { get; set; }

    public int FaqcategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Path { get; set; } = null!;

    public bool Visible { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Faqcategory Faqcategory { get; set; } = null!;
}
