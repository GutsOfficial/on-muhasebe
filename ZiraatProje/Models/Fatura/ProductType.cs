using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Fatura
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        public string ProductName { get; set; }
        public float Stock { get; set; }
        public bool StockCheck { get; set; }

        public float Amount { get; set; }
        public string? ProductNo { get; set; }

        public DateTime Date { get; set; }
        public DateTime LastDate { get; set; }
        public string? Unit { get; set; }
        public float BuyPrice { get; set; }
        public float SellPrice { get; set; }
        public float TaxBuyPrice { get; set; }
        public float TaxSellPrice { get; set; }
        public float KDV { get; set; } = 20;
        public string? Description { get; set; }
        public ICollection<InvoiceProductType> InvoiceProductTypes { get; set; }
    }
}
