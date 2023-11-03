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
    public partial class SupplierPayment : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public SupplierPayment(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void SupplierPayment_Load(object sender, EventArgs e)
        {
            var item = context.Suppliers.FirstOrDefault(x => x.SupplierId == deger);
            if (item != null)
            {
                if (item.Balance < 0)
                {
                    meblagtbx.Text = (item.Balance - (2 * item.Balance)).ToString();
                }
                else
                {
                    meblagtbx.Text = context.Receipts.Where(x => x.SupplierId == deger).Sum(x => x.LastTotal).ToString();
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
        float remainingAmount;
        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(meblagtbx.Text, out float meblağ))
            {
                var supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == deger);
                if (meblağ > 0 && deger != 0)
                {
                    // Belirli bir müşteriye ait vadesi geçmemiş ve lastTotal değeri pozitif faturaları al
                    var supplierReceipts = context.Receipts
                        .Where(x => x.SupplierId == deger && x.LastTotal > 0 && x.PaymentDate <= DateTime.Now)
                        .OrderBy(x => x.PaymentDate) // Ödeme tarihine göre sırala
                        .ToList();

                    if (supplierReceipts.Any())
                    {
                        remainingAmount = meblağ;

                        foreach (var item in supplierReceipts)
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


                                context.Receipts.Update(item);
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"{meblağ - remainingAmount} TL Kasadan çekildi.");

                        if (remainingAmount > 0)
                        {
                            MessageBox.Show($"Girilen meblağ, tüm Fişleri ödemek için yetersiz.");
                        }
                        // Müşterinin bakiyesinden de ödeme yap
                        supplier.Balance += remainingAmount;
                        var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                        vault.Balance -= (meblağ);
                        context.Vaults.Update(vault);

                        context.Suppliers.Update(supplier);
                        context.SaveChanges();
                        MessageBox.Show($"{meblağ} TL Tedarikçi Bakiyesine eklendi");

                        this.Close();
                    }
                    else
                    {
                        // Müşteriye ait ödenecek fatura bulunamadığında, müşterinin bakiyesinden çek

                        supplier.Balance += meblağ;
                        var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                        vault.Balance -= (meblağ);
                        context.Vaults.Update(vault);
                        context.Suppliers.Update(supplier);
                        context.SaveChanges();

                        MessageBox.Show($"{meblağ} TL Tedarikçi Bakiyesine ");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
