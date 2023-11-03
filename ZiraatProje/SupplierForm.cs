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
using ZiraatProje.Models.Giderler;

namespace ZiraatProje
{
    public partial class SupplierForm : Form
    {
        AddSupplier Addsupplier;
        ZiraatContext context = new ZiraatContext();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Addsupplier == null)
            {
                Addsupplier = new AddSupplier();
                Addsupplier.FormClosed += AddReceipt_FormClosed;

                Addsupplier.Dock = DockStyle.Fill;

                Addsupplier.Show();
            }
            else
            {
                Addsupplier.Activate();
            }
        }
        private void AddReceipt_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Addsupplier = null;
            LoadData();

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            supplierData.Rows.Clear();
            supplierData.Columns.Clear();
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.HeaderText = "Müşteri ID"; // Sütun başlığı (gözükecek metin)
            column.Visible = false; // Sütunu gizle
            supplierData.Columns.Add(column);
            supplierData.Columns.Add("MusteriAdi", "Tedarikçi Adı");
            supplierData.Columns.Add("İletisim", "İletişim");
            supplierData.Columns.Add("Borc", "Borç Tutarı");

            float totalDebt = 0;

            // DataGridViewCellStyle nesnesi oluşturarak hata rengini ayarlayın
            DataGridViewCellStyle errorStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            foreach (var supplier in context.Suppliers.ToList())
            {
                var receipts = context.Receipts
                    .Include(i => i.Supplier)
                    .Where(i => i.Supplier.SupplierId == supplier.SupplierId)
                    .ToList();

                float customerTotalDebt = 0;
                toplamlbl.Text = context.Suppliers.Count().ToString();
                // Müşterinin tüm faturalarını kontrol edin
                foreach (var receipt in receipts)
                {
                    if (receipt.PaymentDate < DateTime.Today)
                    {
                        // Eğer ödeme tarihi geçtiyse, hata rengini ayarlayın
                        foreach (DataGridViewRow row in supplierData.Rows)
                        {
                            if (row.Cells["MusteriAdi"].Value != null && row.Cells["MusteriAdi"].Value.ToString() == supplier.SupplierName)
                            {
                                hatalbl.Visible = true;
                                hatalbl.Text = "Hata: Ödeme Tarihi Geçmiş!";
                                hatalbl.ForeColor = Color.Red;
                                row.DefaultCellStyle = errorStyle;
                            }
                        }
                    }
                }

                foreach (var invoice in receipts)
                {
                    customerTotalDebt += (float)invoice.LastTotal;
                }

                supplierData.Rows.Add(supplier.SupplierId, supplier.SupplierName, supplier.SupplierName, customerTotalDebt);
                totalDebt += customerTotalDebt;
            }

            // TahsilLbl'e toplam borcu yazdır
            tahsillbl.Text = totalDebt.ToString("C");
        }

        private void supplierData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücre tıklamadan dolayı olmayan hücrelerin tıklamalarını kontrol etmek için
            {
                DataGridViewCell selectedCell = supplierData.Rows[e.RowIndex].Cells[0];
                int id = (int)selectedCell.Value; // Tıklanan hücrenin değerini alın

                SupplierInfo info = new SupplierInfo(id);
                info.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Refresh();
        }
    }
}
