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
    public partial class FaturaDetails : Form
    {
        ZiraatContext context = new ZiraatContext();
        private int deger;
        public FaturaDetails(int cellValue)
        {
            InitializeComponent();
            deger = cellValue;
        }

        private void FaturaDetails_Load(object sender, EventArgs e)
        {

            LoadData();


        }

        private void LoadData()
        {

            var invoice = context.Invoices.Include(x => x.InvoiceProductTypes).FirstOrDefault(x => x.Id == deger);

            if (invoice != null)
            {
                if (invoice.LastTotal <= 0)
                {
                    tahsilPanel.Visible = true;
                }
                else
                {
                    errorPanel.Visible = true;
                }

                label10.Text = invoice.InvoiceDate.ToString();
                PaymentTypelbl.Text = invoice.IsPaid.ToString();
                var customer = context.Customers.FirstOrDefault(x => x.CustomerId == invoice.CustomerId);
                CustomerNamelbl.Text = customer.CustomerFullName.ToString();

                InvoiceData.Columns.Clear();
                InvoiceData.Columns.Add("Product", "Hizmet / Ürün");
                InvoiceData.Columns.Add("Amount", "Miktar");
                InvoiceData.Columns.Add("AmountPrice", "Birim Fiyatı");
                InvoiceData.Columns.Add("KDV", "Vergi");
                InvoiceData.Columns.Add("Total", "Toplam");
                foreach (var item in invoice.InvoiceProductTypes)
                {
                    foreach (var product in context.ProductTypes.Where(x => x.ProductTypeId == item.ProductTypeId))
                    {
                        InvoiceData.Rows.Add(product.ProductName, $"{product.Amount}  {product.Unit}", product.SellPrice, $"Kdv %{product.KDV}", invoice.LastTotal);
                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        FaturaTahsilat FaturaTahsilat;
        private void button3_Click(object sender, EventArgs e)
        {
            FaturaTahsilat = new FaturaTahsilat(deger);
            FaturaTahsilat.Show();
            this.Close();
            FaturaTahsilat.FormClosed += FaturaTahsilat_FormClosed;
        }

        private void FaturaTahsilat_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadData();
        }
    }
}
