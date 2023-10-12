using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWSApi.Models.MedicalStaff;

public partial class MedicalStaffVM
{
    [Required]
    public int MedicalStaffId { get; set; }

    [Required]
    public string PersonalNumber { get; set; } = null!;

    [Required]
    public string LicenceNumber { get; set; } = null!;

    [Required]
    public string Firstname { get; set; } = null!;

    [Required]
    public string Lastname { get; set; } = null!;

    [Required]
    public string Specialization { get; set; } = null!;

    [Required]
    public string Status { get; set; } = null!;

   

    
}
