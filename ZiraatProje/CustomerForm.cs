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
    public partial class CustomerForm : Form
    {
        ZiraatContext context = new ZiraatContext();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.HeaderText = "Müşteri ID"; // Sütun başlığı (gözükecek metin)
            column.Visible = false; // Sütunu gizle
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns.Add("MusteriAdi", "Müşteri Adı");
            dataGridView1.Columns.Add("İletisim", "İletişim");
            dataGridView1.Columns.Add("Borc", "Borç Tutarı");

            float totalDebt = 0;

            // DataGridViewCellStyle nesnesi oluşturarak hata rengini ayarlayın
            DataGridViewCellStyle errorStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            foreach (var customer in context.Customers.OrderByDescending(x => x.CreatedDate).ToList())
            {
                var invoices = context.Invoices
                    .Include(i => i.CustomerInfo)
                    .Where(i => i.CustomerInfo.CustomerId == customer.CustomerId)
                    .ToList();

                float customerTotalDebt = 0;
                toplamlbl.Text = context.Customers.Count().ToString();
                // Müşterinin tüm faturalarını kontrol edin
                foreach (var invoice in invoices)
                {
                    if (invoice.PaymentDate < DateTime.Today)
                    {
                        // Eğer ödeme tarihi geçtiyse, hata rengini ayarlayın
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MusteriAdi"].Value != null && row.Cells["MusteriAdi"].Value.ToString() == customer.CustomerFullName)
                            {
                                hatalbl.Visible = true;
                                hatalbl.Text = "Hata: Ödeme Tarihi Geçmiş!";
                                hatalbl.ForeColor = Color.Red;
                                row.DefaultCellStyle = errorStyle;
                            }
                        }
                    }
                }

                foreach (var invoice in invoices)
                {
                    customerTotalDebt += (float)invoice.LastTotal;
                }

                dataGridView1.Rows.Add(customer.CustomerId, customer.CustomerFullName, customer.NickName, customerTotalDebt);
                totalDebt += customerTotalDebt;
            }

            // TahsilLbl'e toplam borcu yazdır
            tahsillbl.Text = totalDebt.ToString("C");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                int cellValue = Convert.ToInt32(selectedCell.Value);

                CustomerInfo info = new CustomerInfo(cellValue);

                // Eğer CustomerInfo formu daha önce açılmışsa kapat
                foreach (Form form in Application.OpenForms)
                {
                    if (form is CustomerInfo)
                    {
                        form.Close();
                        break;
                    }
                }

                info.FormClosed += (sender, args) =>
                {
                    // CustomerInfo formu kapatıldığında bu kod çalışır
                    this.Show(); // Ana formu tekrar görünür yap
                };

                this.Hide(); // Ana formu gizle
                info.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            addCustomer.FormClosed += (sender, args) =>
            {
                LoadData();
            };
        }
    }
}
