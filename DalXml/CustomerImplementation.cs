using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using Tools;

namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        const string path = @"..\xml\customers.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer>? customers;
        private List<Customer> LoadList()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                customers = xmlSerializer.Deserialize(sr) as List<Customer>;

            }
            return customers;
        }
        private void SaveList(List<Customer> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, list);
            }
        }



        public Customer? Read(Func<Customer, bool>? filter)
        {
            customers=LoadList();
            LogManager.WriteToLog("start read customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = customers.FirstOrDefault(c => filter(c));
            if (q != null)
            {
                LogManager.WriteToLog("finish read customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return q;
            }
            LogManager.WriteToLog("לא נמצא לקוח שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalNotfoundObjectWithThisFilterException("לא נמצא לקוח שעונה על תנאי זה");
        }
        public int Create(Customer item)
        {
            customers = LoadList();
            LogManager.WriteToLog("start to create customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = customers.Any(i => i.Id == item.Id);
            if (q)
            {
                LogManager.WriteToLog("קיים לקוח עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                throw new DalIdExistsException("קיים לקוח עם מספר מזהה זה");
            }
            customers.Add(item);
            SaveList(customers);
            LogManager.WriteToLog("finish to create customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return item.Id;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLog("start to delete customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            customers = LoadList();
            var q = customers.FirstOrDefault(i => i.Id == id);
            if (q != null)
            {
                customers.Remove(q);
                SaveList(customers);
                LogManager.WriteToLog("finish to delete customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            }
            else
            {
                LogManager.WriteToLog("לא נמצא לקוח עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                throw new DalIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה");
            }
        }


        public Customer? Read(int id)
        {
            customers = LoadList();
            LogManager.WriteToLog("start to read customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            //var q = from c in customers
            //        where c.Id == id
            //        select c;
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                LogManager.WriteToLog("finish to read customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return customer;
            }
            LogManager.WriteToLog("לא נמצא לקוח עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה");
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter)
        {
            customers = LoadList();
            LogManager.WriteToLog("start to read all customer/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            if (filter == null)
            {
                LogManager.WriteToLog("finish to read all customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return customers;
            }
            var q = customers.Where(c => filter(c));
            LogManager.WriteToLog("finish to read customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return q.ToList();
        }

        public void Update(Customer item)
        {
            LogManager.WriteToLog("start to upadate customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            Delete(item.Id);
            Create(item);
            LogManager.WriteToLog("finish to update customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        }
    }

}
