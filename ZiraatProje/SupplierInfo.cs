using Microsoft.EntityFrameworkCore;
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
    public partial class SupplierInfo : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public SupplierInfo(int id)
        {
            InitializeComponent();
            deger = id;
        }

        private void SupplierInfo_Load(object sender, EventArgs e)
        {
            var supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == deger);
            if (supplier != null)
            {
                supplierNamelbl.Text = supplier.SupplierName;
                supplierPhone.Text = supplier.PhoneNumber;
                supplierMail.Text = supplier.Email;
                balancelbl.Text = supplier.Balance.ToString();

                supplierData.Rows.Clear();
                supplierData.Columns.Clear();
                var column = new DataGridViewTextBoxColumn();
                column.Name = "Id"; // Sütunun adı
                column.HeaderText = "Müşteri ID"; // Sütun başlığı (gözükecek metin)
                column.Visible = false; // Sütunu gizle
                supplierData.Columns.Add(column);
                supplierData.Columns.Add("MusteriAdi", "Fatura Adı");
                supplierData.Columns.Add("FaturaNo", "Belge No");
                supplierData.Columns.Add("Date", "Düzenlenme Tarihi");
                supplierData.Columns.Add("vadeDate", "Vade Tarihi");
                supplierData.Columns.Add("Meblag", "Kalan Meblağ");

                float totalDebt = 0;

                // DataGridViewCellStyle nesnesi oluşturarak hata rengini ayarlayın
                DataGridViewCellStyle errorStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Red,
                    ForeColor = Color.White
                };
                float allTotal = 0;

                // 'deger' değişkenini nasıl elde ediyorsanız, bu kodu değiştirerek ona göre ayarlayın.
                // Örneğin, aşağıdaki gibi bir şekilde tanımlayabilirsiniz:
                // string deger = CustomerName.Text;

                // Müşterinin tüm faturalarını alın


                foreach (var receipt in context.Receipts
                    .Include(i => i.Supplier)
                    .Where(i => i.Supplier.SupplierId == deger)
                    .OrderByDescending(i => i.Date)
                    .ToList())
                {

                    balancelbl.Text = receipt.Supplier.Balance.ToString();
                    supplierData.Rows.Add(
                        receipt.ReceiptId,
                        receipt.ReceiptName,
                        receipt.ReceiptNo,
                        receipt.Date,
                        receipt.PaymentDate,
                        receipt.LastTotal


                    );

                    float totalLastTotal = context.Receipts.Sum(i => i.LastTotal);

                    bakiyelbl.Text = totalLastTotal.ToString();
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierPayment supplierPayment = new SupplierPayment(deger);
            supplierPayment.Show();
            this.Close();
            supplierPayment.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierTahsilat tahsilat = new SupplierTahsilat(deger);
            tahsilat.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
