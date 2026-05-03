using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal static class Config
    {

        const string path = @"..\xml\data-config.xml";
        const string PRODUCTID = "ProductId";
        const string SALEID = "SaleId";
        static XElement dataConfigXml = XElement.Load(path);

        public static int GetProductId
        {
            get
            {
                int ProductId=int.Parse(dataConfigXml.Element(PRODUCTID).Value);
                ProductId++;
                dataConfigXml.Element(PRODUCTID).SetValue(ProductId.ToString());
                dataConfigXml.Save(path);
                return ProductId;
            }
        }

        public static int GetSaleId
        {
            get
            {
                int SaleId=int.Parse(dataConfigXml.Element(SALEID).Value);
                SaleId++;
                dataConfigXml.Element(SALEID).SetValue(SaleId.ToString());
                dataConfigXml.Save(path);
                return SaleId;
            }
        }
    }
}

