using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
            public static string ToStringProperty<T>(this T obj)
            {
                return ToStringPropertyInternal(obj, 0);
            }
            private static string ToStringPropertyInternal(object obj, int indent)
            {
                if (obj == null)
                    return "null";

                string spaces = new string(' ', indent * 2);
                Type t = obj.GetType();
                string result = "";

                if (t.IsPrimitive|| t.IsEnum || obj is string || obj is DateTime || obj is decimal)
                {
                    return obj.ToString();
                }

                if (obj is System.Collections.IEnumerable list && !(obj is string))
                {
                    result += "[\n";
                    foreach (var item in list)
                    {
                        result += spaces + "  " + ToStringPropertyInternal(item, indent + 1) + ",\n";
                    }
                    result += spaces + "]";
                    return result;
                }

                result += t.Name + " {\n";

                foreach (PropertyInfo prop in t.GetProperties())
                {
                    var value = prop.GetValue(obj);
                    result += spaces + "  " + prop.Name + ": " +
                              ToStringPropertyInternal(value, indent + 1) + "\n";
                }

                result += spaces + "}";

                return result;
            }
        public static DO.Sale convertBOSaleToDOSale(this BO.Sale obj)
        {
            return new DO.Sale(obj.Id, obj.ProductId, obj.QuantityRequier, obj.SalePrice, obj.IsSaleToCustomer, obj.StartSale, obj.EndSale);
        }
        public static BO.Sale convertBOSaleToDOSale(this DO.Sale obj)
        {
            return new BO.Sale()
            { 
                Id = obj.Id,
                ProductId = obj.ProductId,
                QuantityRequier = obj.QuantityRequier,
                SalePrice = obj.SalePrice,
                IsSaleToCustomer = obj.IsSaleToCustomer,
                StartSale = obj.StartSale,
                EndSale = obj.EndSale
            };
        }
        public static DO.Customer convertBOCustomerToDOCustomer(this BO.Customer obj)
        {
            return new DO.Customer(obj.Id, obj.CustomerName, obj.Adress, obj.Phone);
        }
        public static BO.Customer convertDOCustomerToBOCustomer(this DO.Customer obj)
        {
            return new BO.Customer()
            {
               Id = obj.Id,
               CustomerName = obj.CustomerName,
               Adress = obj.Adress,
               Phone = obj.Phone
            };
        }
        public static DO.Product convertBOProductToDOProduct(this BO.Product obj)
        {
            return new DO.Product(obj.Id, obj.ProductName,(DO.Categories)obj.Category, obj.Price, obj.Stock);
        }
        public static BO.Product convertDOProductToBOProduct(this DO.Product obj)
        {
            if (obj == null)
                return null;
            return new BO.Product()
            {
               Id = obj.Id,
               ProductName = obj.ProductName,
               Category=(BO.Categories)obj.Category,
               Price = obj.Price,
               Stock = obj.Stock
            };
        }
    }
}
