
namespace Dal;
using DO;
using DalApi;

internal class CustomerImplementation:ICustomer
{
    public int Create(Customer item)
    {

        foreach (Customer? i in DataSource.Customers)
        {
            if (item.Id == i?.Id)
                throw new Exception("קיים לקוח עם מספר מזהה זה");
        }
        DataSource.Customers.Add(item);
        return item.Id;
    }

    public void Delete(int id)
    {
        foreach (Customer? item in DataSource.Customers)
        {
            if (item?.Id == id)
            { DataSource.Customers.Remove(item); return; }
        }
        throw new Exception("לא נמצא לקוח עם מספר מזהה זה");
    }

    public Customer? Read(int id)
    {
        foreach (Customer? item in DataSource.Customers)
        {
            if (item?.Id == id)
                return item;
        }
        return null;
    }

    public List<Customer?> ReadAll()
    {
        return new List<Customer?>(DataSource.Customers);
    }

    public void Update(Customer item)
    {
        foreach (Customer? i in DataSource.Customers)
        {
            if (i?.Id == item.Id)
            {
                DataSource.Customers.Remove(i);
                DataSource.Customers.Add(item);
                return;
            }
        }
        throw new Exception("לא נמצא לקוח עם מספר מזהה זה.");
    }
}
