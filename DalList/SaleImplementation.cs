

namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;

internal class SaleImplementation : ISale
{
    public Sale? Read(Func<Sale, bool>? filter)
    {
        var q = DataSource.Sales.FirstOrDefault(c => filter(c));
        if (q != null)
            return q;
        throw new DalNotfoundObjectWithThisFilterException("לא נמצא מבצע שעונה על תנאי זה");
    }
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetSaleId;
        Sale newSale = item with { Id = newId };
        DataSource.Sales.Add(newSale);
        return newSale.Id;
    }

    public void Delete(int id)
    {
        var q = DataSource.Sales.FirstOrDefault(i => i.Id == id);
        if (q != null)
            DataSource.Sales.Remove(q);
        else
            throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
    }

    public Sale? Read(int id)
    {
        var q = from c in DataSource.Sales
                where c.Id == id
                select c;
        if (q != null)
            return (Sale)q;
        throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter)
    {
        if (filter == null)
            return new List<Sale?>(DataSource.Sales);
        var q = DataSource.Sales.Where(c => filter(c));
        return q.ToList();
    }

    public void Update(Sale item)
    {
        Delete(item.Id);
        Create(item);
    }
}
