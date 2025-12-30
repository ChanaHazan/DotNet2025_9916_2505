using System;
using System.Collections.Generic;
using System.Linq;
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
    public record Product
        (
          int Id,
          string? ProductName,
          Categries Category,
          double? Price,
          int? Stock
        )
    {
        public Product()
            : this(0, null,Categries.Fish, null,0)
        {

        }
    }
}
