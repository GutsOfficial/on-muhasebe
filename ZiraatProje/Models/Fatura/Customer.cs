using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiraatProje.Models.Fatura;

namespace ZiraatProje.Models.Fatura
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string? NickName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public bool? Status { get; set; }
        public int? PaymentNo { get; set; }
        public string? TaxNo { get; set; }
        public float Balance { get; set; }
        public bool IsTuzel { get; set; }
        public string? TC { get; set; }
        public string? VergiDairesi { get; set; }
        public string? PaymentAccount { get; set; }
        public List<Invoice>? Invoices { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
