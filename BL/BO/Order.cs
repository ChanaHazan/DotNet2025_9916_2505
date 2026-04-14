using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace BO;

public class Order
{
    public bool IsPreferredCudtomer { get; set; }
    public List<Product> ProductInOrder { get; set; }
    public double TotalPrice { get; set; }

    public override string ToString() => this.ToStringProperty();
}
