using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiraatProje.Models.Giderler;

namespace ZiraatProje.Models.Fatura
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string? PaymentNumber { get; set; }
        public int CustomerId { get; set; } // Hangi müşteriye ait olduğunu belirtmek için
        public Customer? Customer { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
