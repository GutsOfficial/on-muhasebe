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
    public partial class ReceiptPayment : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public ReceiptPayment(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void ReceiptPayment_Load(object sender, EventArgs e)
        {
            var firstItem = context.Vaults.FirstOrDefault(x => x.VaultId == 1);
            meblagtbx.Text = context.Receipts.FirstOrDefault(x => x.ReceiptId == deger).LastTotal.ToString();
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
            if (float.TryParse(meblagtbx.Text, out float meblağ))
            {
                if (meblağ > 0 && deger != 0)
                {
                    var item = context.Receipts.FirstOrDefault(x => x.ReceiptId == deger);

                    if (item != null)
                    {

                        if (meblağ <= (float)item.LastTotal)
                        {
                            item.LastTotal = (float)(item.LastTotal - meblağ);
                            if (item.LastTotal < 0)
                            {
                                item.IsPaid = true;
                                item.LastTotal = 0;
                            }
                            var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                            vault.Balance -= meblağ;
                            context.Receipts.Update(item);
                            context.Vaults.Update(vault);
                            context.SaveChanges();
                            MessageBox.Show($"{meblağ} TL Kasadan çekildi");
                            FaturaDetails ReceiptInfo = new FaturaDetails(item.ReceiptId);
                            ReceiptInfo.Show();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
