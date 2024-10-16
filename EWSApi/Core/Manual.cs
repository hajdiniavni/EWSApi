using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class Manual
{
    public int ManualId { get; set; }

    public string RoleId { get; set; } = null!;

    public string TitleSq { get; set; } = null!;

    public string? TitleEn { get; set; }

    public string? TitleSr { get; set; }

    public string PathSq { get; set; } = null!;

    public string? PathEn { get; set; }

    public string? PathSr { get; set; }

    public bool Active { get; set; }

    public string InsertedFrom { get; set; } = null!;

    public DateTime InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual AspNetUsers InsertedFromNavigation { get; set; } = null!;

    public virtual AspNetRoles Role { get; set; } = null!;

    public virtual AspNetUsers? UpdatedFromNavigation { get; set; }
}
