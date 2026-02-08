

namespace Dal;
using DO;
using DalApi;
internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {
        int newId = DataSource.Config.GetProductId;
        Product newProduct = item with { Id = newId };
        DataSource.Products.Add(newProduct);
        return newProduct.Id;
    }

    public void Delete(int id)
    {
        foreach (Product? item in DataSource.Products)
        {
            if (item?.Id == id)
            { DataSource.Products.Remove(item); return; }
        }
        throw new Exception("לא נמצא מוצר עם קוד זה");
    }

    public Product? Read(int id)
    {
        foreach (Product? item in DataSource.Products)
        {
            if (item?.Id == id)
                return item;
        }
        return null;
    }

    public List<Product?> ReadAll()
    {
        return new List<Product?>(DataSource.Products);
    }

    public void Update(Product item)
    {
        Delete(item.Id);
        Create(item);
    }
}
