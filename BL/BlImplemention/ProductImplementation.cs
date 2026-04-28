
using BlApi;
using BO;
using DO;

namespace BlImplemention
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.convertBOProductToDOProduct()); 
            }
            catch (DO.DalIdExistsException innerExeption)
            {
                throw new BO.BlIdExistsException("The customer is Exist!", innerExeption);
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                var boProduct = (_dal.Product.Read(id)).convertDOProductToBOProduct();
                if (boProduct != null)
                {
                    AllAvailableSales(boProduct);
                }
                return boProduct;
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא מוצר עם מספר מזהה זה", ex);
            }
        }

        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            var list = _dal.Product.ReadAll()
                .Select(c => c.convertDOProductToBOProduct());

            if (filter != null)
                list = list.Where(filter);

            var productsList = list.ToList();

            productsList.ForEach(p => AllAvailableSales(p));

            return productsList;
        }

        public void Update(BO.Product item)
        {
            try
            {
            _dal.Product.Update(item.convertBOProductToDOProduct());

            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא מבצע עם מספר מזהה זה", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                var product = _dal.Product.Read(p => filter(p.convertDOProductToBOProduct()));
                return product.convertDOProductToBOProduct();
            }
            catch (DO.DalNotfoundObjectWithThisFilterException ex)
            {
                throw new BO.BlNotfoundObjectWithThisFilterException("לא נמצא לקוח שעונה על תנאי זה", ex);

            }
        }

        public void AllAvailableSales(BO.Product product)
        {
            try
            {
                var sales = _dal.Sale.ReadAll(s =>
                s.ProductId == product.Id
                //צריך לבדוק פה שהמבצע בתוקף
                 //&& s.StartSale <= DateTime.Now &&
                 // s.EndSale <= DateTime.Now
                );


                product.SaleList = sales.Select(s => new SaleInProduct
                {
                    IsSaleToAllCustomer = s.IsSaleToCustomer,
                    SaleId = s.Id,
                    Price = s.SalePrice,
                    QuantityRequire=s.QuantityRequier
                }).OrderBy(s => s.Price).ToList();
                
            }
            catch(Exception ex) 
            {
                throw new Exception("שגיאה בשליפת מבצעים למוצר", ex);
            }

        }

    }
}
