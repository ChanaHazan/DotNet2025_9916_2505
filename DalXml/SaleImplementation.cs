using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tools;

namespace Dal
{
    internal class SaleImplementation :ISale
    {
        const string PRODUCTID = "ProductId";
        const string ENDSALE = "EndSale";
        const string STARTSALE = "StartSale";
        const string ISSALETOCUSTOMER = "IsSaleToCustomer";
        const string QUANTITYREQUIER = "QuantityRequier";
        const string SALEPRICE = "SalePrice";
        const string SALE = "Sale";
        const string ID = "id";

        const string path = @"..\xml\sales.xml";
        XElement sales;
        private XElement LoadXElement()
        {
            XElement saleXml=XElement.Load(path);
            return saleXml;
        }
        public Sale? Read(Func<Sale, bool>? filter)
        {
            sales= LoadXElement();
            LogManager.WriteToLog("start read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q= (from s in sales.Elements(SALE)
                   select new Sale()
                   {
                       Id = (int)s.Element(ID),
                       ProductId = (int)s.Element(PRODUCTID),
                       SalePrice = (double)s.Element(SALEPRICE),
                       QuantityRequier = (int)s.Element(QUANTITYREQUIER),
                       IsSaleToCustomer = (bool)s.Element(ISSALETOCUSTOMER),
                       StartSale = (DateTime)s.Element(STARTSALE),
                       EndSale = (DateTime)s.Element(ENDSALE)
                   }).ToList();
            if (filter != null)
            {
                LogManager.WriteToLog("finish read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return q.FirstOrDefault(s=>filter(s));
            }
            LogManager.WriteToLog("לא נמצא מבצע שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalNotfoundObjectWithThisFilterException("לא נמצא מבצע שעונה על תנאי זה");
        }
        public int Create(Sale item)
        {
            sales = LoadXElement();
            LogManager.WriteToLog("start to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            int newId =Config.GetSaleId;
            Sale newSale = item with { Id = newId };
            sales.Add(new XElement
                (SALE,
                new XElement(ID, newSale.Id),
                new XElement(PRODUCTID, newSale.ProductId),
                new XElement(SALEPRICE, newSale.SalePrice),
                new XElement(QUANTITYREQUIER, newSale.QuantityRequier),
                new XElement(ISSALETOCUSTOMER, newSale.IsSaleToCustomer),
                new XElement(STARTSALE, newSale.StartSale),
                new XElement(ENDSALE, newSale.EndSale)));
            sales.Save(path);
            LogManager.WriteToLog("finish to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return newSale.Id;
        }

       
        public void Delete(int id)
        {
            sales= LoadXElement();
            LogManager.WriteToLog("start to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = (from s in sales.Elements(SALE)
                     where int.Parse(s.Element(ID).Value) == id
                     select s).FirstOrDefault();
            if (q != null)
            {
                LogManager.WriteToLog("finish to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                q.Remove();
                sales.Save(path);
            }
            else
            {
                LogManager.WriteToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
            }
        }

        public Sale? Read(int id)
        {
            sales = LoadXElement();
            LogManager.WriteToLog("start to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = (from s in sales.Elements(SALE)
                    where int.Parse(s.Element(ID).Value) == id
                    select s).FirstOrDefault();
            if (q != null)
            {
                LogManager.WriteToLog("finish to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return new Sale()
                {
                    Id = (int)q.Element(ID),
                    ProductId = (int)q.Element(PRODUCTID),
                    SalePrice = (double)q.Element(SALEPRICE),
                    QuantityRequier = (int)q.Element(QUANTITYREQUIER),
                    IsSaleToCustomer = (bool)q.Element(ISSALETOCUSTOMER),
                    StartSale = (DateTime)q.Element(STARTSALE),
                    EndSale = (DateTime)q.Element(ENDSALE)
                };
            }
            LogManager.WriteToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            throw new DalIdNotFoundException("לא נמצא מבצע עם קוד זה");
        }
        public List<Sale?> ReadAll(Func<Sale, bool>? filter)
        {
            sales=LoadXElement();
            LogManager.WriteToLog("start to read all sale/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var sa = (from s in sales.Elements(SALE)
                      select new Sale()
                      {
                          Id = (int)s.Element(ID),
                          ProductId = (int)s.Element(PRODUCTID),
                          SalePrice = (double)s.Element(SALEPRICE),
                          QuantityRequier = (int)s.Element(QUANTITYREQUIER),
                          IsSaleToCustomer = (bool)s.Element(ISSALETOCUSTOMER),
                          StartSale = (DateTime)s.Element(STARTSALE),
                          EndSale = (DateTime)s.Element(ENDSALE)

                      }).ToList();
            if (filter == null)
            {
                LogManager.WriteToLog("finish to read all sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return sa;
            }
            else
            {
               LogManager.WriteToLog("finish to read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return sa.Where(s=>filter(s)).ToList();
            }
        }

        public void Update(Sale item)
        {
            LogManager.WriteToLog("start to upadate sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            Delete(item.Id);
            Create(item);
            LogManager.WriteToLog("finish to update sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        }
    }
}
