using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BlImplemention
{
    internal class OrderImplemention : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {
            int count = productInOrder.Amount, severalTimes = 0;
            double sum = 0;
            List<BO.SaleInProduct> salesInUsing = new List<BO.SaleInProduct>();
            foreach (var sale in productInOrder.SalesList)
            {
                if (count >= sale.QuantityRequire)
                {
                    severalTimes = count / sale.QuantityRequire;
                    sum += severalTimes * (sale.Price ?? 0);
                    count -= severalTimes * sale.QuantityRequire;
                    salesInUsing.Add(sale);
                    if (count == 0)
                        break;
                }
            }
            productInOrder.SalesList = salesInUsing;
            if (count > 0)
            {
                sum += count * productInOrder.BasePrice;
            }
            productInOrder.TotalPrice = sum;

        }
        public void CalcTotalPrice(BO.Order order)
        {
            order.TotalPrice = (from Product in order.ProductInOrder
                                select Product.TotalPrice).Sum();
        }
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
        {
            try
            {
                DO.Product product = _dal.Product.Read(productId);
                var existingProduct = order.ProductInOrder.Find(p => p.ProductId == product.Id);
                if (existingProduct != null)
                {
                    if (amount + existingProduct.Amount > product.Stock)
                    {
                        throw new BO.BLThereIsNotEnoughInStock("אין מספיק במלאי");
                    }
                    existingProduct.Amount += amount;
                }
                else
                {
                    if (amount > product.Stock)
                    {
                        throw new BO.BLThereIsNotEnoughInStock("אין מספיק במלאי");
                    }
                    var NewProductInOrder = new BO.ProductInOrder
                    {
                        ProductId = product.Id,
                        ProductName = product.ProductName,
                        BasePrice = product.Price ?? 0,
                        Amount = amount
                    };

                    order.ProductInOrder.Add(NewProductInOrder);
                    existingProduct = NewProductInOrder;
                    SearchSaleForProduct(existingProduct, true);
                    CalcTotalPriceForProduct(existingProduct);
                    CalcTotalPrice(order);
                }
                return existingProduct.SalesList;
            }

            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא מוצר עם מספר מזהה זה", ex);
            }
        }
        public void SearchSaleForProduct(BO.ProductInOrder product, bool isOrderToExistCustomer)
        {
            product.SalesList= _dal.Sale.ReadAll(s =>
               s.ProductId == product.ProductId &&
               s.StartSale <= DateTime.Now &&
               s.EndSale <= DateTime.Now &&
               s.QuantityRequier == product.Amount &&
               (s.IsSaleToCustomer || isOrderToExistCustomer))
               .Select(s => new BO.SaleInProduct()
               {
                   IsSaleToAllCustomer = s.IsSaleToCustomer,
                   Price = s.SalePrice,
                   QuantityRequire = s.QuantityRequier,
                   SaleId = s.Id
               })
              .OrderBy(s => s.Price / s.QuantityRequire).ToList();
        }

        public void DoOrder(BO.Order order)
        {
            var updates = from item in order.ProductInOrder
                          let dalProduct = _dal.Product.Read(item.ProductId)
                          select dalProduct with { Stock = dalProduct.Stock - item.Amount };

            foreach (var updatedProduct in updates)
            {
                _dal.Product.Update(updatedProduct);
            }
        }

    }
}     


   
