using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseNotification
{
    public int DiseaseNotificationId { get; set; }

    public int? TypeId { get; set; }

    public int DiseaseInfectionId { get; set; }

    public int HealthInstitutionId { get; set; }

    public string Url { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public virtual DiseaseInfection DiseaseInfection { get; set; } = null!;

    public virtual ICollection<DiseaseNotificationAspNetUser> DiseaseNotificationAspNetUser { get; set; } = new List<DiseaseNotificationAspNetUser>();

    public virtual ICollection<DiseaseNotificationReportRegister> DiseaseNotificationReportRegister { get; set; } = new List<DiseaseNotificationReportRegister>();

    public virtual HealthInstitution HealthInstitution { get; set; } = null!;
}
