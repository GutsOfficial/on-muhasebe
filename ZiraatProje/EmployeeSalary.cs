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
using ZiraatProje.Models.Fatura;
using ZiraatProje.Models.Giderler;

namespace ZiraatProje
{
    public partial class EmployeeSalary : Form
    {
        ZiraatContext context = new ZiraatContext();
        int? deger;
        public EmployeeSalary(int? id)
        {
            InitializeComponent();
            deger = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeSalary_Load(object sender, EventArgs e)
        {
            if (deger != 0)
            {
                EmployeeName.Text = context.Employees.FirstOrDefault(x => x.EmployeeId == deger).EmployeeName;
            }

        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (EmployeeName.Text != "")
            {
                employeecbx.Items.Clear();
                foreach (var item in context.Employees.Where(x => x.EmployeeName.Contains(EmployeeName.Text)))
                {
                    employeecbx.Items.Add(item.EmployeeName);
                }
                employeecbx.DroppedDown = true;

            }
        }
        int type;
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                var employee = context.Employees.FirstOrDefault(c => c.EmployeeName == EmployeeName.Text);
                if (employee == null)
                {
                    employee = new Employee
                    {
                        EmployeeName = EmployeeName.Text,

                    };
                    context.Employees.Add(employee);
                }
                else
                {
                    if (employee.Balance > 0)
                    {
                        employee.Balance -= (float)Convert.ToDouble(salaryTotal.Text);

                        if (employee.Balance < 0)
                        {
                            // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                            this.Invoke((MethodInvoker)delegate
                            {
                                salaryTotal.Text = (employee.Balance * -1).ToString();
                            });
                            employee.Balance = 0;
                        }
                        else
                        {
                            // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                            this.Invoke((MethodInvoker)delegate
                            {
                                salaryTotal.Text = "0";
                            });
                        }
                        context.Employees.Update(employee);
                    }

                }


                var salary = new Salary
                {
                    SalaryName = SalaryName.Text,
                    Employee = employee,
                    DeservDate = salaryDate.Value,
                    IsPaid = IsPaidcbx.Checked,
                    CurrencyType = type,
                    PaymentDate = (IsPaidcbx.Checked == false) ? PaymentDate.Value : DateTime.Now,
                    Total = (float)Convert.ToDouble(salaryTotal.Text),
                    LastTotal = (float)Convert.ToDouble(salaryTotal.Text),

                };


                context.Salaries.Add(salary);
                context.SaveChanges();
            });

            MessageBox.Show("İşlem tamamlandı.");
            this.Close();
        }

        private void TLrbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }
    }
}
