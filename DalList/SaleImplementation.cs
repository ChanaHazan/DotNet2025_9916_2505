

namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetSaleId();
        Sale newSale = item with { Id = newId };
        foreach (Sale i in DataSource.Sales)
        {
            if (newSale.Id == i.Id)
                throw new Exception("קיים מבצע עם קוד זה");
        }
        DataSource.Sales.Add(newSale);
        return newSale.Id;
    }

    public void Delete(int id)
    {
        foreach (Sale item in DataSource.Sales)
        {
            if(item.Id==id)
            { DataSource.Sales.Remove(item); return; }
        }
        throw new Exception("לא נמצא מבצע עם קוד זה");
    }

    public Sale? Read(int id)
    {
        foreach (Sale item in DataSource.Sales)
        {
            if (item.Id == id)
                return item;
        }
        return null;
    }

    public List<Sale?> ReadAll()
    {
        return DataSource.Sales;    
    }

    public void Update(Sale item)
    {
        foreach (Sale i in DataSource.Sales)
        {
            if (i.Id == item.Id)
            {
                DataSource.Sales.Remove(i);
                DataSource.Sales.Add(item);
                return;
            }
        }
        throw new Exception("לא נמצא מבצע עם מזהה זה.");
    }
}
