using System;
using System.Collections.Generic;

namespace EWSApi.Models;

public partial class Faqcategory
{
    public int FaqcategoryId { get; set; }

    public string NameSq { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public string DescriptionSq { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public string DescriptionSr { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int? Position { get; set; }

    public bool IsActive { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<FaqcategoryGroup> FaqcategoryGroup { get; set; } = new List<FaqcategoryGroup>();

    public virtual ICollection<Faqquestion> Faqquestion { get; set; } = new List<Faqquestion>();

    public virtual ICollection<Faqvideo> Faqvideo { get; set; } = new List<Faqvideo>();

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;
}
