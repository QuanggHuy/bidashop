using System;
using System.Collections.Generic;

namespace Authentication.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public double Price { get; set; }

    public double Discount { get; set; }

    public int CategoryId { get; set; }

    public string Brand { get; set; }

    public string Origin { get; set; }

    public string Guarantee { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
