

namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;

internal class ProductImplementation:IProduct
{
    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.WriteToLog("start read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = DataSource.Products.FirstOrDefault(c => filter(c));
        if (q != null)
        {
            LogManager.WriteToLog("finish read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return q;
        }
        LogManager.WriteToLog("לא נמצא פריט שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        throw new DalNotfoundObjectWithThisFilterException("לא נמצא פריט שעונה על תנאי זה");
    }
    public int Create(Product item)
    {
        LogManager.WriteToLog("start to create product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        int newId = DataSource.Config.GetProductId;
        Product newProduct = item with { Id = newId };
        DataSource.Products.Add(newProduct);
        LogManager.WriteToLog("finish to create product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        return newProduct.Id;
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog("start to delete product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        var q = DataSource.Products.FirstOrDefault(i => i.Id == id);
        if (q != null)
        {
            DataSource.Products.Remove(q);
            LogManager.WriteToLog("finish to delete product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        }
        else
        {
            LogManager.WriteToLog("לא נמצא מוצר עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            throw new DalIdNotFoundException("לא נמצא מוצר עם קוד זה");}
    }

    public Product? Read(int id)
    {
        LogManager.WriteToLog("start to read product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        var q = from c in DataSource.Products
                where c.Id == id
                select c;
        if (q != null)
        {
            LogManager.WriteToLog("finish to read product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return (Product)q;
        }
        LogManager.WriteToLog("לא נמצא מוצר עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        throw new DalIdNotFoundException("לא נמצא מוצר עם קוד זה");
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter)
    {
        LogManager.WriteToLog("start to read all product/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        if (filter == null)
        {
            LogManager.WriteToLog("finish to read all product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return new List<Product?>(DataSource.Products);
        }
        var q = DataSource.Products.Where(c => filter(c));
        LogManager.WriteToLog("finish to read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        return q.ToList();
    }

    public void Update(Product item)
    {
        LogManager.WriteToLog("start to upadate product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        Delete(item.Id);
        Create(item);
        LogManager.WriteToLog("finish to update product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
    }
}
