using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplemention
{
    internal class SaleImplementation:ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
    }
}
