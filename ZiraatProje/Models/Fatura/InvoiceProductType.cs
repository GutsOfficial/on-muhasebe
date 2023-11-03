using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Fatura
{
    public class InvoiceProductType
    {
        [Key]
        public int Id { get; set; }

        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; }
    }
}
