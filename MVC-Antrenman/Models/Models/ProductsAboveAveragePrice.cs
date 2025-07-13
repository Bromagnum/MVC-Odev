using System;
using System.Collections.Generic;

namespace MVC_Antrenman.Models.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
