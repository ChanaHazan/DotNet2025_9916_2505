using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
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
        public int Id { get; init; }
        public string? Phone { get; set; }
        public string? CustomerName { get; set; }
        public string? Adress { get; set; }

        public override string ToString() => this.ToStringProperty();
       
    }
}
