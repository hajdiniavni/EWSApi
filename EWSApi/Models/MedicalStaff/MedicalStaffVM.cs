﻿using System;
using System.Collections.Generic;

namespace EWSApi.Models.MedicalStaff;

public partial class MedicalStaffVM
{
    public int MedicalStaffId { get; set; }

    public string PersonalNumber { get; set; } = null!;

    public string LicenceNumber { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Specialization { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? InsertedFrom { get; set; } = null!;

    public DateTime? InsertedDate { get; set; }

    public string? UpdatedFrom { get; set; }

    public DateTime? UpdatedDate { get; set; }

    
}