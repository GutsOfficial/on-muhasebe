using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiraatProje.Models.Giderler
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string? TC { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? PaymentNo { get; set; }
        public float Balance { get; set; }
        public virtual ICollection<Salary>? Salaries { get; set; }


    }
}
