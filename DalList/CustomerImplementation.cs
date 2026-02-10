
namespace Dal;
using DO;
using DalApi;

internal class CustomerImplementation:ICustomer
{
    public Customer? Read(Func<Customer, bool>? filter)
    {
        var q = DataSource.Customers.FirstOrDefault(c => filter(c));
        if (q != null)
            return q;
        throw new DalNotfoundObjectWithThisFilterException("לא נמצא לקוח שעונה על תנאי זה");
    }
    public int Create(Customer item)
    {
        var q= DataSource.Customers.Any(i=>i.Id==item.Id);
        if (q)
           throw new DalIdExistsException("קיים לקוח עם מספר מזהה זה");
        DataSource.Customers.Add(item);
        return item.Id;
    }

    public void Delete(int id)
    {
        var q = DataSource.Customers.FirstOrDefault(i => i.Id == id);
        if(q!=null)
            DataSource.Customers.Remove(q);
        else
            throw new DalIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה");
    }

    public Customer? Read(int id)
    {
        var q=from c in DataSource.Customers
              where c.Id == id
              select c;
        if(q!=null)
            return (Customer)q;
        throw new DalIdNotFoundException("לא נמצא לקוח עם מספר מזהה זה");
    }

    public List<Customer?> ReadAll(Func<Customer,bool>? filter)
    {
        if (filter==null)
            return new List<Customer?>(DataSource.Customers);
        var q=DataSource.Customers.Where(c => filter(c));
        return q.ToList();  
    }

    public void Update(Customer item)
    {
        Delete(item.Id);
        Create(item);
    }
}
