

using BlApi;
using static BO.Tools;

namespace BlImplemention
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.convertBOCustomerToDOCustomer());

            }

            catch (DO.DalIdExistsException innerExeption)
            {
                throw new BO.BlIdExistsException("The customer is Exist!", innerExeption);
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                return (_dal.Customer.Read(id)).convertDOCustomerToBOCustomer();
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה", ex);
            }
        }

        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            var list = _dal.Customer.ReadAll(null)
                .Select(c => c.convertDOCustomerToBOCustomer());

            if (filter != null)
                list = list.Where(filter);

            return list.ToList();
        }

        public void Update(BO.Customer item)
        {
            try
            {
            _dal.Customer.Update(item.convertBOCustomerToDOCustomer());

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
                _dal.Customer.Delete(id);
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה", ex);
            }
        }
        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                var list = _dal.Customer.ReadAll(null)
                            .Select(c => c.convertDOCustomerToBOCustomer());

                return list.FirstOrDefault(filter);
            }
            catch (DO.DalNotfoundObjectWithThisFilterException ex)
            {
                throw new BO.BlNotfoundObjectWithThisFilterException("לא נמצא לקוח שעונה על תנאי זה", ex);

            }
        }
        public bool IsExists(int id)
        {
            var list = _dal.Customer.ReadAll(null);
            return list.Any(c => c.Id == id);
        }
    }
}
