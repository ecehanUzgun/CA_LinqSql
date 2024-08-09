using System;
using System.Collections.Generic;

namespace CA_LinqSql.models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
