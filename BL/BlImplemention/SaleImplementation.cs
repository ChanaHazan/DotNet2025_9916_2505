using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplemention
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(Sale item)
        {
            return _dal.Sale.Create(item.convertBOSaleToDOSale());
        }
        public BO.Sale? Read(int id)
        {
            try
            {
                return (_dal.Sale.Read(id)).convertDOSaleToBOSale();
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא מבצע עם מספר מזהה זה", ex);
            }
        }
        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            var list = _dal.Sale.ReadAll(null)
            .Select(s => s.convertDOSaleToBOSale());

            if (filter != null)
                list = list.Where(filter);

            return list.ToList();

        }

        public void Update(Sale item)
        {
            try
            {
                _dal.Sale.Update(item.convertBOSaleToDOSale());
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
                _dal.Sale.Delete(id);
            }
            catch (DO.DalIdNotFoundException ex)
            {
                throw new BO.BLIdNotFoundException("לא נמצא מבצע עם מספר מזהה זה", ex);
            }
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            try
            {
                var list = _dal.Sale.ReadAll(null)
                            .Select(c => c.convertDOSaleToBOSale());

                return list.FirstOrDefault(filter);
            }
            catch (DO.DalNotfoundObjectWithThisFilterException ex)
            {
                throw new BO.BlNotfoundObjectWithThisFilterException("לא נמצא מבצע שעונה על תנאי זה", ex);
            }
        }
            


    }
}
