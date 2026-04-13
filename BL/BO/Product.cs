using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// ישות מוצר 
    /// בקצביה שלנו 
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="ProductName"></param>
    /// <param name="Category"></param>
    /// <param name="Price"></param>
    /// <param name="Stock"></param>
    public class Product
    {   
        public int Id { get; set; }
        public int? Stock { get; set; }
        public double? Price { get; set; }
        public string? ProductName { get; set; }
        public Categories Category  { get; set; }
        public List<Sale>? SaleList { get; set; }
        public Product()
        {

        }
    }
}
