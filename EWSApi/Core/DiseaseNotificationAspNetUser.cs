using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class DiseaseNotificationAspNetUser
{
    public int DiseaseNotificationAspNetUserId { get; set; }

    public int DiseaseNotificationId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Read { get; set; }

    public virtual DiseaseNotification DiseaseNotification { get; set; } = null!;

    public virtual AspNetUsers User { get; set; } = null!;
}
