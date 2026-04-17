using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplemention
{
    internal class OrderImplemention:IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        //List<SaleInProduct> AddProductToOrder(Order order, int productId, int amount);

        //void CalcTotalPriceForProduct(ProductInOrder productInOrder);

        //void CalcTotalPrice(Order order);
        //void DoOrder(Order order);

        //void SearchSaleForProduct(ProductInOrder productInOrder);


    }
}
