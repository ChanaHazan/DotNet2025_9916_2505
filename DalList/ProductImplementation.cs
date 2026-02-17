

namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;

internal class ProductImplementation:IProduct
{
    public Product? Read(Func<Product, bool>? filter)
    {
        var q = DataSource.Products.FirstOrDefault(c => filter(c));
        if (q != null)
        {
            LogManager.WriteToLog("read Product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return q;
        }
        throw new DalNotfoundObjectWithThisFilterException("לא נמצא פריט שעונה על תנאי זה");
    }
    public int Create(Product item)
    {
        int newId = DataSource.Config.GetProductId;
        Product newProduct = item with { Id = newId };
        DataSource.Products.Add(newProduct);
        LogManager.WriteToLog("created Product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        return newProduct.Id;
    }

    public void Delete(int id)
    {
        var q = DataSource.Products.FirstOrDefault(i => i.Id == id);
        if (q != null)
        {
            DataSource.Products.Remove(q);
            LogManager.WriteToLog("deleted Product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        }
        else
            throw new DalIdNotFoundException("לא נמצא מוצר עם קוד זה");
    }

    public Product? Read(int id)
    {
        var q = from c in DataSource.Products
                where c.Id == id
                select c;
        if (q != null)
        {
            LogManager.WriteToLog("read customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return (Product)q;
        }
        throw new DalIdNotFoundException("לא נמצא מוצר עם קוד זה");
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter)
    {
        if (filter == null)
            return new List<Product?>(DataSource.Products);
        var q = DataSource.Products.Where(c => filter(c));
        return q.ToList();
    }

    public void Update(Product item)
    {
        Delete(item.Id);
        Create(item);
    }
}
