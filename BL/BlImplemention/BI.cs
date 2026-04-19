using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplemention
{
    internal class BI:IBI
    {
        public ICustomer ICustomer => new CustomerImplementation();
        public IProduct IProduct =>new ProductImplementation();
        public ISale ISale => new SaleImplementation();
        public IOrder IOrder => new OrderImplemention();
    }
}
