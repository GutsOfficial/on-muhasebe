using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Fatura
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public string InvoiceName { get; set; }
        public Customer CustomerInfo { get; set; }
        public int CustomerId { get; set; }     
        public DateTime InvoiceDate { get; set; }
        public int InvoiceSerialNo { get; set; }
        public int InvoiceSuquenceNo { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public int CurrencyType { get; set; }
        public float Total { get; set; }
        public float LastTotal { get; set; }
        public ICollection<InvoiceProductType> InvoiceProductTypes { get; set; }
    }
}
