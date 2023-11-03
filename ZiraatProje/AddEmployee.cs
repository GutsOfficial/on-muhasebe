using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
    public partial class AddEmployee : Form
    {
        ZiraatContext context = new ZiraatContext();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeName = EmployeeNametbx.Text,
                TC = TCNotbx.Text,
                PhoneNumber = Phonenumbertbx.Text,
                Email = mailtbx.Text,
                EntryDate = entryDate.Value,
                ExitDate = outdate.Value,
                PaymentNo = IBANtbx.Text
            };
            context.Employees.Add(employee);
            context.SaveChanges();
            this.Close();
            MessageBox.Show("İşlem tamam");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
