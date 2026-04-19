
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
                return (_dal.Product.Read(id)).convertDOProductToBOProduct();
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה", ex);
            }
        }

        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            var list = _dal.Product.ReadAll(null)
                .Select(c => c.convertDOProductToBOProduct());

            if (filter != null)
                list = list.Where(filter);

            return list.ToList();
        }

        public void Update(BO.Product item)
        {
            _dal.Product.Update(item.convertBOProductToDOProduct());
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
                var list = _dal.Product.ReadAll(null)
                            .Select(c => c.convertDOProductToBOProduct());

                return list.FirstOrDefault(filter);
            }
            catch (DO.DalNotfoundObjectWithThisFilterException ex)
            {
                throw new BO.BlNotfoundObjectWithThisFilterException("לא נמצא לקוח שעונה על תנאי זה", ex);

            }
        }

        public void AllAvailableSales(BO.ProductInOrder product, bool isPreferdCustomer)
        {
            try
            {
                var sales = _dal.Sale.ReadAll(s =>
                s.ProductId == product.ProductId &&
                s.StartSale <= DateTime.Now &&
                s.EndSale <= DateTime.Now &&
                (s.IsSaleToCustomer || isPreferdCustomer));

                product.SalesList = sales.Select(s => new SaleInProduct
                {
                    IsSaleToAllCustomer = s.IsSaleToCustomer,
                    SaleId = s.Id,
                    Price = s.SalePrice
                }).OrderBy(s => s.Price).ToList();

            }
            catch(Exception ex) 
            {
                throw new Exception("שגיאה בשליפת מבצעים למוצר", ex);
            }

        }

    }
}
