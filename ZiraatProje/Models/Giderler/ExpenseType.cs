using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Giderler
{
    public class ExpenseType
    {
        [Key]
        public int ExpenseTypeId { get; set; }
        public string ExpenseName { get; set; }

        public List<Receipt> Receipts { get; set; }
    }
}
