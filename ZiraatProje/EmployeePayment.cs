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

namespace ZiraatProje
{
    public partial class EmployeePayment : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public EmployeePayment(int id)
        {

            InitializeComponent();
            deger = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            var item = context.Employees.FirstOrDefault(x => x.EmployeeId == deger);
            if (item != null)
            {
                if (item.Balance < 0)
                {
                    meblagtbx.Text = (item.Balance - (2 * item.Balance)).ToString();
                }
                else
                {
                    meblagtbx.Text = context.Salaries.Where(x => x.EmployeeId == deger).Sum(x => x.LastTotal).ToString();
                }
                var firstItem = context.Vaults.FirstOrDefault(x => x.VaultId == 1);

                if (firstItem != null)
                {
                    // ComboBox'a ilk öğeyi ekleyin ve seçili yapın
                    comboBox1.Items.Add(firstItem.VaultName);
                    comboBox1.SelectedItem = firstItem.VaultName;

                    // Diğer öğeleri işlemek için ayrı bir döngü veya LINQ kullanabilirsiniz
                    foreach (var vault in context.Vaults.Skip(1))
                    {
                        comboBox1.Items.Add(vault.VaultName);
                    }
                }
            }
        }

        private void meblagtbx_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((float)Convert.ToDouble(meblagtbx.Text) > 0)
            {
                var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                if (vault != null)
                {
                    var salaries = context.Salaries.Where(x => x.EmployeeId == deger).ToList();
                    if (salaries.Any())
                    {

                    }
                    else
                    {
                        vault.Balance -= (float)Convert.ToDouble(meblagtbx.Text);
                        var employee = context.Employees.FirstOrDefault(x => x.EmployeeId == deger);
                        if (employee != null)
                        {
                            employee.Balance += (float)Convert.ToDouble(meblagtbx.Text);
                            context.Employees.Update(employee);
                            context.Vaults.Update(vault);
                            context.SaveChanges();
                            MessageBox.Show($"{meblagtbx.Text} TL Kasadan düşüldü.");

                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
