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
    public partial class SupplierTahsilat : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public SupplierTahsilat(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void meblagtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void SupplierTahsilat_Load(object sender, EventArgs e)
        {
            var supplierReceipt = context.Receipts.Where(x => x.SupplierId == deger && x.LastTotal > 0).ToList();

            Lasttotallbl.Text = supplierReceipt.Sum(x => x.LastTotal).ToString();
            if (supplierReceipt.Sum(x => x.LastTotal) != 0)
            {
                meblagtbx.Text = (context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance > 0)
                                    ? (context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance + supplierReceipt.Sum(x => x.LastTotal)).ToString() : supplierReceipt.Sum(x => x.LastTotal).ToString();
            }
            else
            {
                meblagtbx.Text = (context.Suppliers.FirstOrDefault(x => x.SupplierId == deger).Balance > 0) ? context.Suppliers.FirstOrDefault(x => x.SupplierId == deger).Balance.ToString() : 0.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((float)Convert.ToDouble(meblagtbx.Text) > 0)
            {
                var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                if (vault != null)
                {
                    vault.Balance += (float)Convert.ToDouble(meblagtbx.Text);
                    var supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == deger);
                    if (supplier != null)
                    {
                        supplier.Balance -= (float)Convert.ToDouble(meblagtbx.Text);
                        context.Suppliers.Update(supplier);
                        context.Vaults.Update(vault);
                        context.SaveChanges();
                        MessageBox.Show($"{meblagtbx.Text} TL Kasaya eklendi.");

                        this.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
