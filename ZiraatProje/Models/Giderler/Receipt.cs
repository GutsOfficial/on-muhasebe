using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Giderler
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }
        public string ReceiptName { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public int ExpenseTypeId { get; set; }
        public ExpenseType? ExpenseType { get; set; }
        public int ReceiptNo { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public float KDV { get; set; }
        public float KDVAmount { get; set; }
        public float Total { get; set; }
        public float LastTotal { get; set; }
        public bool IsPaid { get; set; }
        public int PaymentType { get; set; }
        public string? EmplayeeName { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
