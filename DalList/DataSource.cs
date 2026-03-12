
namespace Dal;
using DO;
using System.Xml.Linq;

internal static class DataSource
{
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    
    internal static class Config
    {
        const string path = @"xml\data-config.xml";
        const string PRODUCTID = "productId";
        const string SALEID = "saleId";
        static XElement dataConfigXml = XElement.Load(path);
        private static int ProductId= int.Parse(dataConfigXml.Element(PRODUCTID).Value);
        private static int myVar; //מיותר?!


        public static int GetProductId
        {
            get
            {
                ProductId++;
                dataConfigXml.Element(PRODUCTID).SetValue(ProductId.ToString());
                dataConfigXml.Save(path);
                return ProductId;
            }
        }


        private static int SaleId = int.Parse(dataConfigXml.Element(SALEID).Value);

        public static int GetSaleId
        {
            get
            {
                SaleId++;
                dataConfigXml.Element(SALEID).SetValue(SaleId.ToString());
                dataConfigXml.Save(path);
                return SaleId;
            }
        }
    }

}
