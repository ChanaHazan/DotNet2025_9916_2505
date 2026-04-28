using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        const string path = @"..\xml\products.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
        List<Product>? products;
        private List<Product> LoadList()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                products = xmlSerializer.Deserialize(sr) as List<Product>;

            }
            return products;
        }
        private void SaveList(List<Product> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, list);
            }
        }



        public Product? Read(Func<Product, bool>? filter)
        {
            products = LoadList();
            LogManager.WriteToLog("start read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = products.FirstOrDefault(p => filter(p));
            if (q != null)
            {
                LogManager.WriteToLog("finish read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return q;
            }
            LogManager.WriteToLog("לא נמצא מוצר שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalNotfoundObjectWithThisFilterException("לא נמצא מוצר שעונה על תנאי זה");

        }
        public int Create(Product item)
        {
            products = LoadList();
            LogManager.WriteToLog("start to create product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            int newId = Config.GetProductId;
            Product newProduct = item with { Id = newId };
            products.Add(newProduct);
            SaveList(products);
            LogManager.WriteToLog("finish to create product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return newProduct.Id;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLog("start to delete product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            products = LoadList();
            var q = products.FirstOrDefault(i => i.Id == id);
            if (q != null)
            {
                products.Remove(q);
                SaveList(products);
                LogManager.WriteToLog("finish to delete customer by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            }
            else
            {
                LogManager.WriteToLog("לא נמצא מוצר עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                throw new DalIdNotFoundException("לא נמצא מוצר עם מספר מזהה זה");
            }
        }

        public Product? Read(int id)
        {
            products = LoadList();
            LogManager.WriteToLog("start to read product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            List<Product> q = (from p in products
                               where p.Id == id
                               select p).ToList();
            if (q != null&&q.Count>0)
            {
                LogManager.WriteToLog("finish to read product by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return q.FirstOrDefault();
            }

            LogManager.WriteToLog("לא נמצא מוצר עם מספר מזהה זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalIdNotFoundException("לא נמצא מוצר עם מספר מזהה זה");
        }


        public List<Product?> ReadAll(Func<Product, bool>? filter)
        {
            products = LoadList();
            LogManager.WriteToLog("start to read all product/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            if (filter == null)
            {
                LogManager.WriteToLog("finish to read all products", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return products;
            }
            var q = products.Where(p => filter(p));
            LogManager.WriteToLog("finish to read product by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return q.ToList();
        }

        //public void Update(Product item)
        //{
        //    LogManager.WriteToLog("start to upadate product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        //    Delete(item.Id);
        //    Create(item);
        //    LogManager.WriteToLog("finish to update product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
        //}

        public void Update(Product newItem)
        {
            LogManager.WriteToLog("start to update product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var products = LoadList();

            var existingProduct = products.FirstOrDefault(p => p.Id == newItem.Id);

            if (existingProduct != null)
            {
                Product updatedProduct = existingProduct with
                {
                    ProductName = !string.IsNullOrWhiteSpace(newItem.ProductName) ? newItem.ProductName : existingProduct.ProductName,

                    Category = newItem.Category,

                    Price = newItem.Price ?? existingProduct.Price,

                    Stock = newItem.Stock ?? existingProduct.Stock
                };
                int index = products.IndexOf(existingProduct);
                products[index] = updatedProduct;

                SaveList(products);

                LogManager.WriteToLog("finish to update product", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            }
            else
            {
                LogManager.WriteToLog("מוצר לא נמצא לעדכון", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                throw new DalIdNotFoundException($"מוצר עם מספר {newItem.Id} לא נמצא במערכת.");
            }
        }

    }
}
