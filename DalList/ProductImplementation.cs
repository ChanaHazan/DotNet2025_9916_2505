

namespace Dal;
using DO;
using DalApi;
internal class ProductImplementation:IProduct
{
    public Product? Read(Func<Product, bool>? filter)
    {
        var q = DataSource.Products.FirstOrDefault(c => filter(c));
        if (q != null)
            return q;
        throw new DalNotfoundObjectWithThisFilterException("לא נמצא פריט שעונה על תנאי זה");
    }
    public int Create(Product item)
    {
        int newId = DataSource.Config.GetProductId;
        Product newProduct = item with { Id = newId };
        DataSource.Products.Add(newProduct);
        return newProduct.Id;
    }

    public void Delete(int id)
    {
        var q = DataSource.Products.FirstOrDefault(i => i.Id == id);
        if (q != null)
            DataSource.Products.Remove(q);
        else
            throw new DalIdNotFoundException("לא נמצא מוצר עם קוד זה");
    }

    public Product? Read(int id)
    {
        var q = from c in DataSource.Products
                where c.Id == id
                select c;
        if (q != null)
            return (Product)q;
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
