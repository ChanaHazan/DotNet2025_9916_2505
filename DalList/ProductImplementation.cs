

namespace Dal;
using DO;
using DalApi;
internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {

        //האם צריך להשתמש פה בקונפיגורציה??
        foreach (Product i in DataSource.Products)
        {
            if (item.Id == i.Id)
                throw new Exception("קיים מבצע עם קוד זה");
        }
        DataSource.Products.Add(item);
        return item.Id;
    }

    public void Delete(int id)
    {
        foreach (Product item in DataSource.Products)
        {
            if (item.Id == id)
            { DataSource.Products.Remove(item); return; }
        }
        throw new Exception("לא נמצא מבצע עם קוד זה");
    }

    public Product? Read(int id)
    {
        foreach (Product item in DataSource.Products)
        {
            if (item.Id == id)
                return item;
        }
        return null;
    }

    public List<Product?> ReadAll()
    {
        return DataSource.Products;
    }

    public void Update(Product item)
    {
        foreach (Product i in DataSource.Products)
        {
            if (i.Id == item.Id)
            {
                DataSource.Products.Remove(i);
                DataSource.Products.Add(item);
                return;
            }
        }
        throw new Exception("לא נמצא מבצע עם מזהה זה.");
    }
}
