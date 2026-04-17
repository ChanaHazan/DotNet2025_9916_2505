using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; init; }
        public string ProductName { get; set; }
        public double BasePrice { get; set; }
        public int Amount { get; set; }
        public List<SaleInProduct> SalesList { get; set; }
        public double TotalPrice { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}
