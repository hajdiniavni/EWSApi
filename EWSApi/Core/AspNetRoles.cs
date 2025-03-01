﻿using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class AspNetRoles
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string Description { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string NameSq { get; set; } = null!;

    public string NameSr { get; set; } = null!;

    public virtual ICollection<AspNetRoleClaims> AspNetRoleClaims { get; set; } = new List<AspNetRoleClaims>();

    public virtual ICollection<FaqcategoryGroup> FaqcategoryGroup { get; set; } = new List<FaqcategoryGroup>();

    public virtual ICollection<Manual> Manual { get; set; } = new List<Manual>();

    public virtual ICollection<RealRole> RealRole { get; set; } = new List<RealRole>();

    public virtual ICollection<AspNetUsers> User { get; set; } = new List<AspNetUsers>();
}
