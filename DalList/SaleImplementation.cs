

namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetSaleId;
        Sale newSale = item with { Id = newId };
        DataSource.Sales.Add(newSale);
        return newSale.Id;
    }

    public void Delete(int id)
    {
        foreach (Sale? item in DataSource.Sales)
        {
            if(item?.Id==id)
            { DataSource.Sales.Remove(item); return; }
        }
        throw new Exception("לא נמצא מבצע עם קוד זה");
    }

    public Sale? Read(int id)
    {
        foreach (Sale? item in DataSource.Sales)
        {
            if (item?.Id == id)
                return item;
        }
        return null;
    }

    public List<Sale?> ReadAll()
    {
        return new List<Sale?>(DataSource.Sales);    
    }

    public void Update(Sale item)
    {
        Delete(item.Id);
        Create(item);
    }
}
