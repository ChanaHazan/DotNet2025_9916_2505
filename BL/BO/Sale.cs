using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// ישות מבצע
    /// בקצביה שלנו
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="ProductId"></param>
    /// <param name="QuantityRequier"></param>
    /// <param name="SalePrice"></param>
    /// <param name="IsSaleToCustomer"></param>
    /// <param name="StartSale"></param>
    /// <param name="EndSale"></param>
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double? SalePrice { get; set; }
        public int QuantityRequier { get; set; }
        public bool IsSaleToCustomer { get; set; }
        public DateTime? StartSale { get; set; }
        public DateTime? EndSale { get; set; }
        public Sale()
        {
        }
    }
}
