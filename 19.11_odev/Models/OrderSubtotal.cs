using System;
using System.Collections.Generic;

namespace _19._11_odev.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
