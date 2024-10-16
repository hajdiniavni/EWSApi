using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseNotificationReportRegister
{
    public int DiseaseNotificationReportRegisterId { get; set; }

    public int DiseaseNotificationId { get; set; }

    public int ReportRegisterId { get; set; }

    public DateTime InsertedDate { get; set; }

    public virtual DiseaseNotification DiseaseNotification { get; set; } = null!;

    public virtual ReportRegister ReportRegister { get; set; } = null!;
}
