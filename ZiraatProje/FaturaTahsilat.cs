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
    public partial class FaturaTahsilat : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public FaturaTahsilat(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FaturaTahsilat_Load(object sender, EventArgs e)
        {

            var firstItem = context.Vaults.FirstOrDefault(x => x.VaultId == 1);
            var item2 = context.Invoices.FirstOrDefault(x => x.Id == deger);
            Lasttotallbl.Text = item2.LastTotal.ToString();
            meblagtbx.Text = item2.LastTotal.ToString();

            if (firstItem != null)
            {
                // ComboBox'a ilk öğeyi ekleyin ve seçili yapın
                comboBox1.Items.Add(firstItem.VaultName);
                comboBox1.SelectedItem = firstItem.VaultName;

                // Diğer öğeleri işlemek için ayrı bir döngü veya LINQ kullanabilirsiniz
                foreach (var item in context.Vaults.Skip(1))
                {
                    comboBox1.Items.Add(item.VaultName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(meblagtbx.Text, out float meblağ))
            {
                if (meblağ > 0 && deger != 0)
                {
                    var item = context.Invoices.FirstOrDefault(x => x.Id == deger);

                    if (item != null)
                    {

                        if (meblağ <= (float)item.LastTotal)
                        {
                            item.LastTotal = (float)(item.LastTotal - meblağ);
                            if (item.LastTotal < 0)
                            {
                                item.IsPaid = true;
                            }
                            var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                            vault.Balance += meblağ;
                            context.Invoices.Update(item);
                            context.Vaults.Update(vault);
                            context.SaveChanges();
                            MessageBox.Show($"{meblağ} TL Kasaya Eklendi");
                            FaturaDetails faturaDetails = new FaturaDetails(item.Id);
                            faturaDetails.Show();

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Girilen meblağ, fatura toplamından fazla olamaz.");
                        }
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
    }
}
