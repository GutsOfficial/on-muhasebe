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
    public partial class CustomerInfo : Form
    {
        private int deger;
        ZiraatContext context = new ZiraatContext();
        public CustomerInfo(int cellValue)
        {
            InitializeComponent();
            deger = cellValue;
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            acikfaturaData.Rows.Clear();
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.HeaderText = "Müşteri ID"; // Sütun başlığı (gözükecek metin)
            column.Visible = false; // Sütunu gizle
            acikfaturaData.Columns.Add(column);
            acikfaturaData.Columns.Add("MusteriAdi", "Fatura Adı");
            acikfaturaData.Columns.Add("FaturaNo", "Fatura No");
            acikfaturaData.Columns.Add("Date", "Düzenlenme Tarihi");
            acikfaturaData.Columns.Add("vadeDate", "Vade Tarihi");
            acikfaturaData.Columns.Add("Meblag", "Kalan Meblağ");

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


            foreach (var invoice in context.Invoices
                .Include(i => i.CustomerInfo)
                .Include(i => i.InvoiceProductTypes)
                .Where(i => i.CustomerInfo.CustomerId == deger)
                .OrderByDescending(i => i.InvoiceDate)
                .ToList())
            {
                CustomerName.Text = invoice.CustomerInfo.CustomerFullName;
                CustomerPhone.Text = invoice.CustomerInfo.PhoneNumber;
                CustomerMail.Text = invoice.CustomerInfo.Email;
                balancelbl.Text = invoice.CustomerInfo.Balance.ToString();
                acikfaturaData.Rows.Add(
                    invoice.Id,
                    invoice.InvoiceName,
                    $"{invoice.InvoiceSerialNo} {invoice.InvoiceSuquenceNo}",
                    invoice.InvoiceDate,
                    invoice.PaymentDate,
                    invoice.LastTotal
                );

                float totalLastTotal = context.Invoices.Where(x => x.CustomerId == deger).Sum(i => i.LastTotal);

                borclbl.Text = totalLastTotal.ToString();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acikfaturaData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücre tıklamadan dolayı olmayan hücrelerin tıklamalarını kontrol etmek için
            {
                DataGridViewCell selectedCell = acikfaturaData.Rows[e.RowIndex].Cells[0];
                int cellValue = Convert.ToInt32(selectedCell.Value);// Tıklanan hücrenin değerini alın

                FaturaDetails info = new FaturaDetails(cellValue);
                info.Show();
                this.Close();
                info.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerTahsil customerTahsil = new CustomerTahsil(deger);
            customerTahsil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPayment customerPayment = new CustomerPayment(deger);
            customerPayment.Show();
            this.Hide();
        }
    }

}
