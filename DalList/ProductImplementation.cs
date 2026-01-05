

namespace Dal;
using DO;
using DalApi;
internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {
        int newId = DataSource.Config.GetProductId();
        Product newProduct = item with { Id = newId };
        foreach (Product? i in DataSource.Products)
        {
            if (newProduct.Id == i?.Id)
                throw new Exception("קיים מוצר עם קוד זה");
        }
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
        foreach (Product? i in DataSource.Products)
        {
            if (i?.Id == item.Id)
            {
                DataSource.Products.Remove(i);
                DataSource.Products.Add(item);
                return;
            }
        }
        throw new Exception("לא נמצא מוצר עם מזהה זה.");
    }
}
