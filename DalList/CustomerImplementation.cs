
namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class CustomerImplementation : ICustomer
{
    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.WriteToLog("start read customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = DataSource.Customers.FirstOrDefault(c => filter(c));
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
        LogManager.WriteToLog("start to create customer by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = DataSource.Customers.Any(i => i.Id == item.Id);
        if (q)
        {
            LogManager.WriteToLog("קיים לקוח עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalIdExistsException("קיים לקוח עם מספר מזהה זה");
        }
        DataSource.Customers.Add(item);
        LogManager.WriteToLog("finish to create customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        return item.Id;
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog("start to delete customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = DataSource.Customers.FirstOrDefault(i => i.Id == id);
        if (q != null)
        {
            DataSource.Customers.Remove(q);
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
        LogManager.WriteToLog("start to read customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = from c in DataSource.Customers
                where c.Id == id
                select c;
        if (q != null)
        {
            LogManager.WriteToLog("finish to read customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return (Customer)q;
        }
        LogManager.WriteToLog("לא נמצא לקוח עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        throw new DalIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה");
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter)
    {
        LogManager.WriteToLog("start to read all customer/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        if (filter == null)
        {
            LogManager.WriteToLog("finish to read all customer", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return new List<Customer?>(DataSource.Customers);
        }
        var q = DataSource.Customers.Where(c => filter(c));
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
