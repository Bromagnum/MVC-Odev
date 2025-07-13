using System;
using System.Collections.Generic;

namespace MVC_Antrenman.Models.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
