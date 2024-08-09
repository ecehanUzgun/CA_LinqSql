using System;
using System.Collections.Generic;

namespace CA_LinqSql.models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
