using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiraatProje.Models;
using ZiraatProje.Models.Giderler;

namespace ZiraatProje
{
    public partial class EmployeeInfo : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public EmployeeInfo(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            LoadMethod();
        }

        private void LoadMethod()
        {
            var employee = context.Employees.FirstOrDefault(x => x.EmployeeId == deger);
            if (employee != null)
            {

                employeenamelbl.Text = employee.EmployeeName;
                employeephone.Text = employee.PhoneNumber;
                employeeiban.Text = employee.PaymentNo;
                balancelbl.Text = employee.Balance.ToString();
                bakiyelbl.Text = context.Salaries.Where(x => x.EmployeeId == deger).Sum(x => x.Total).ToString();
                employeeData.Rows.Clear();
                employeeData.Columns.Clear();
                var column = new DataGridViewTextBoxColumn();
                column.Name = "Id"; // Sütunun adı
                column.HeaderText = " ID"; // Sütun başlığı (gözükecek metin)
                column.Visible = false; // Sütunu gizle
                employeeData.Columns.Add(column);
                employeeData.Columns.Add("aciklama", "Açıklama");
                employeeData.Columns.Add("type", "İşlem Türü");
                employeeData.Columns.Add("Date", "Düzenlenme Tarihi");
                employeeData.Columns.Add("vadeDate", "Vade Tarihi");
                employeeData.Columns.Add("Meblag", "Tutar");
                foreach (var item in context.Salaries.Where(x => x.EmployeeId == deger))
                {
                    employeeData.Rows.Add(
                    item.SalaryId,
                    "saa",
                    item.CurrencyType,
                    item.DeservDate,
                    item.PaymentDate,
                    item.Total.ToString());
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeSalary salary = new EmployeeSalary(deger);
            salary.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeePayment payment = new EmployeePayment(deger);
            payment.Show();
            Close();
        }
    }
}
