using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; init; }
        public int QuantityRequire { get; set; }
        public double? Price { get; set; }
        public bool IsSaleToAllCustomer { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}
