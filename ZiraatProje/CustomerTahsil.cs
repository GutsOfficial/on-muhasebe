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

namespace ZiraatProje
{
    public partial class CustomerTahsil : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public CustomerTahsil(int id)
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

            var customerInvoices = context.Invoices.Where(x => x.CustomerId == deger && x.LastTotal > 0).ToList();

            Lasttotallbl.Text = customerInvoices.Sum(x => x.LastTotal).ToString();
            if (customerInvoices.Sum(x => x.LastTotal) != 0)
            {
                meblagtbx.Text = (context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance > 0)
                                    ? (context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance + customerInvoices.Sum(x => x.LastTotal)).ToString() : customerInvoices.Sum(x => x.LastTotal).ToString();
            }
            else
            {
                meblagtbx.Text = (context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance > 0) ? context.Customers.FirstOrDefault(x => x.CustomerId == deger).Balance.ToString() : 0.ToString();
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
        float remainingAmount;
        private void button1_Click(object sender, EventArgs e)
        {

            if (float.TryParse(meblagtbx.Text, out float meblağ))
            {
                var customer = context.Customers.FirstOrDefault(x => x.CustomerId == deger);
                if (meblağ > 0 && deger != 0)
                {
                    // Belirli bir müşteriye ait vadesi geçmemiş ve lastTotal değeri pozitif faturaları al
                    var customerInvoices = context.Invoices
                        .Where(x => x.CustomerId == deger && x.LastTotal > 0 && x.PaymentDate <= DateTime.Now)
                        .OrderBy(x => x.PaymentDate) // Ödeme tarihine göre sırala
                        .ToList();

                    if (customerInvoices.Any())
                    {
                        remainingAmount = meblağ;

                        foreach (var item in customerInvoices)
                        {
                            if (remainingAmount > 0)
                            {
                                if (remainingAmount >= (float)item.LastTotal)
                                {
                                    // Eğer meblağ, faturanın LastTotal değerini veya daha fazlasını karşılayabilirse
                                    remainingAmount -= (float)item.LastTotal;
                                    item.LastTotal = 0;
                                    item.IsPaid = true;
                                }
                                else
                                {
                                    // Eğer meblağ, faturanın LastTotal değerini tam olarak karşılayamazsa
                                    item.LastTotal -= remainingAmount;
                                    remainingAmount = 0;
                                }



                                context.Invoices.Update(item);
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"{meblağ - remainingAmount} TL Kasaya Eklendi");

                        if (remainingAmount > 0)
                        {
                            MessageBox.Show($"Girilen meblağ, tüm faturaları ödemek için yetersiz.");
                        }
                        // Müşterinin bakiyesinden de ödeme yap
                        customer.Balance -= remainingAmount;
                        var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                        vault.Balance += meblağ;
                        context.Vaults.Update(vault);
                        context.Customers.Update(customer);
                        context.SaveChanges();
                        MessageBox.Show($"{meblağ} TL Müşteri Bakiyesinden Çekildi");

                        this.Close();
                    }
                    else
                    {
                        // Müşteriye ait ödenecek fatura bulunamadığında, müşterinin bakiyesinden çek

                        customer.Balance -= meblağ;
                        var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                        vault.Balance += (meblağ);
                        context.Vaults.Update(vault);
                        context.Customers.Update(customer);
                        context.SaveChanges();

                        MessageBox.Show($"{meblağ} TL Müşteri Bakiyesinden Çekildi");
                        this.Close();
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

        private void Lasttotallbl_MouseClick(object sender, MouseEventArgs e)
        {
            meblagtbx.Text = Lasttotallbl.Text;
        }

        private void meblagtbx_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
