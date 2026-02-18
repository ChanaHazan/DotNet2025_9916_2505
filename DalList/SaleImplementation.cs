

namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using Tools;

internal class SaleImplementation : ISale
{
    public Sale? Read(Func<Sale, bool>? filter)
    {
        LogManager.WriteToLog("start read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        var q = DataSource.Sales.FirstOrDefault(c => filter(c));
        if (q != null)
        {
            LogManager.WriteToLog("finish read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return q;
        }
        LogManager.WriteToLog("לא נמצא מבצע שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        throw new DalNotfoundObjectWithThisFilterException("לא נמצא מבצע שעונה על תנאי זה");
    }
    public int Create(Sale item)
    {
        LogManager.WriteToLog("start to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        int newId = DataSource.Config.GetSaleId;
        Sale newSale = item with { Id = newId };
        DataSource.Sales.Add(newSale);
        LogManager.WriteToLog("finish to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        return newSale.Id;
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog("start to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = DataSource.Sales.FirstOrDefault(i => i.Id == id);
        if (q != null)
        {
            LogManager.WriteToLog("finish to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            DataSource.Sales.Remove(q);
        }
        else
        {
            LogManager.WriteToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
        }
    }

    public Sale? Read(int id)
    {
        LogManager.WriteToLog("start to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        var q = from c in DataSource.Sales
                where c.Id == id
                select c;
        if (q != null)
        {
            LogManager.WriteToLog("finish to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return (Sale)q;
        }
        LogManager.WriteToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.WriteToLog("start to read all sale/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        if (filter == null)
        {
            LogManager.WriteToLog("finish to read all sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return new List<Sale?>(DataSource.Sales);
        }

        var q = DataSource.Sales.Where(c => filter(c));
        LogManager.WriteToLog("finish to read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        return q.ToList();
    }

    public void Update(Sale item)
    {
        LogManager.WriteToLog("start to upadate sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        Delete(item.Id);
        Create(item);
        LogManager.WriteToLog("finish to update sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

    }
}
