using System;
using System.Collections.Generic;

namespace EWSApi.Core;

public partial class TestType
{
    public int TestTypeId { get; set; }

    public string TestName { get; set; } = null!;

    public string Schema { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime InsertedDate { get; set; }
}
