using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class FaqcategoryGroup
{
    public int FaqcategoryGroupId { get; set; }

    public int FaqcategoryId { get; set; }

    public string RoleId { get; set; } = null!;

    public bool? Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Faqcategory Faqcategory { get; set; } = null!;

    public virtual AspNetRoles Role { get; set; } = null!;
}
