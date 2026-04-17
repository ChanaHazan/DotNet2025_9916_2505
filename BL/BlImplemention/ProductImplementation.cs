
using BlApi;
using BO;

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

        void AllAvailableSales(ProductInOrder productInOrder, bool isPreferdCustomer)
        {
            //לא הבנתי!
        }
    }
}
