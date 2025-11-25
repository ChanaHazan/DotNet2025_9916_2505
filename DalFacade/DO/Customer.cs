using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{   
    /// <summary>
    /// ישות לקוח
    /// בקצביה שלנו
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="CustomerName"></param>
    /// <param name="Adress"></param>
    /// <param name="Phone"></param>
    internal record Customer
        (
          int Id,
          string? CustomerName,
          string? Adress,
          string? Phone
        )
    {
        public Customer():this(0,null,null,null)
        {
                
        }
    }
}
