using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Cash
{
    public class Vault
    {
        [Key]
        public int VaultId { get; set; }
        public string VaultName { get; set; }
        public int CurrencyType { get; set; }
        public DateTime OpenDate { get; set; }
        public float Balance { get; set; }
    }
}
