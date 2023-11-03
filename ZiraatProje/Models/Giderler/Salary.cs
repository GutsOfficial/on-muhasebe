using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Giderler
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
        public string? SalaryName { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public float Total { get; set; }
        public float LastTotal { get; set; }
        public int CurrencyType { get; set; }
        public string? PaymentPart { get; set; }
        public DateTime DeservDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }


    }
}
