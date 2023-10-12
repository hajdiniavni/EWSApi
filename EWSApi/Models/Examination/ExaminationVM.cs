using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EWSApi.Models.Examination;

public partial class ExaminationVM
{
    public int ExaminationId { get; set; }

    [Required]
    public string ExaminationName { get; set; } = null!;

    [Required]
    public string ExaminationCode { get; set; } = null!;

    [Required]
    public bool IsEpidemic { get; set; }

    [Required]
    public int ResultTime { get; set; }

    [Required]
    public int LocalPrice { get; set; }

    [Required]
    public int ForeignPrice { get; set; }

    [Required]
    public bool Active { get; set; }

    [Required]
    public bool IsDynamic { get; set; }



    
}
