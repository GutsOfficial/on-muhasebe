using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Cash
{
    public class BankAccount
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public int? CurrencyType { get; set; }
        public string? BankCode { get; set; }
        public string? Brunch { get; set; }
        public string? AccountNo { get; set; }
        public string? IBAN { get; set; }
        public DateTime BalanceDate { get; set; }
        public float Balance { get; set; }

    }
}
