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
    public class Customer
    {
        public int Id { get; set; }
        public string? Phone { get; set; }
        public string? CustomerName { get; set; }
        public string? Adress { get; set; }
        public Customer()
        {
            
        }
    }
}
