using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiraatProje.Models.Fatura;

namespace ZiraatProje.Models.Giderler
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? NickName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }

        public bool IsTuzel { get; set; }
        public string? TC { get; set; }
        public string? VergiDairesi { get; set; }
        public float Balance { get; set; }
        public string PaymentAccount { get; set; }
    }
}
