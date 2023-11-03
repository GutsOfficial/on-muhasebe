using Bunifu.UI.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZiraatProje
{
    public partial class FaturaDashboard : Form
    {
        ZiraatContext context = new ZiraatContext();
        bool loading = true;
        public FaturaDashboard()
        {
            InitializeComponent();

        }
        BunifuLoader bunifuLoader;
        private void FaturaDashboard_Load(object sender, EventArgs e)
        {

            bunifuLoader = new BunifuLoader();
            bunifuLoader.Location = new Point(681, 164);
            this.Controls.Add(bunifuLoader);
            // Verileri yüklemek için bir iş parçacığı başlat
            Thread loadingThread = new Thread(LoadData);
            loadingThread.Start();




        }



        private void LoadData()
        {


            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.HeaderText = "Müşteri ID"; // Sütun başlığı (gözükecek metin)
            column.Visible = false; // Sütunu gizle


            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns.Add("MusteriAdi", "Müşteri Adı");
            dataGridView1.Columns.Add("FaturaNo", "Fatura No");
            dataGridView1.Columns.Add("Date", "Düzenlenme Tarihi");
            dataGridView1.Columns.Add("vadeDate", "Vade Tarihi");
            dataGridView1.Columns.Add("Meblag", "Kalan Meblağ");

            float totalDebt = 0;

            // DataGridViewCellStyle nesnesi oluşturarak hata rengini ayarlayın
            DataGridViewCellStyle errorStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            float allTotal = 0;

            foreach (var invoice in context.Invoices.Include(i => i.CustomerInfo).Include(x => x.InvoiceProductTypes).ThenInclude(x => x.ProductType).OrderByDescending(i => i.InvoiceDate).ToList())
            {
                float invoiceTotal = 0; // Her faturanın toplam borcu

                foreach (var invoiceProductType in invoice.InvoiceProductTypes)
                {
                    var productType = invoiceProductType.ProductType;
                    if (productType != null)
                    {
                        invoiceTotal += invoice.LastTotal;

                        dataGridView1.Rows.Add(invoice.Id, invoice.CustomerInfo.CustomerFullName, $"{invoice.InvoiceSerialNo} {invoice.InvoiceSuquenceNo}", invoice.InvoiceDate, invoice.PaymentDate, invoice.LastTotal);

                        // Ödeme tarihinin geçip geçmediğini kontrol et
                        if (invoice.PaymentDate < DateTime.Today)
                        {
                            // Eğer ödeme tarihi geçtiyse, hata rengini ayarlayın
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["FaturaNo"].Value != null && row.Cells["FaturaNo"].Value.ToString() == $"{invoice.InvoiceSerialNo} {invoice.InvoiceSuquenceNo}")
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        hatalbl.Visible = true;
                                        hatalbl.Text = "Hata: Ödeme Tarihi Geçmiş!";
                                        hatalbl.ForeColor = Color.Red;
                                        row.DefaultCellStyle = errorStyle;
                                    });
                                }
                            }
                        }
                    }
                }

                totalDebt += invoiceTotal;
            }

            // Tüm müşterilerin toplam borcu hesaplanır ve `allTotal` değişkenine eklenir.
            allTotal = (float)context.Invoices.Sum(c => c.Total);

            // TahsilLbl'e toplam borcu yazdır
            tahsillbl.Text = totalDebt.ToString("C");
            toplamlbl.Text = allTotal.ToString("C");

            this.Invoke((MethodInvoker)delegate
            {
                bunifuLoader.Visible = false;
                panel1.Visible = true;
                dataGridView1.Visible = true;
            });
        }


        FaturaAdd? FaturaAdd;
        private void button1_Click(object sender, EventArgs e)
        {
            if (FaturaAdd == null)
            {
                FaturaAdd = new FaturaAdd();
                FaturaAdd.FormClosed += FaturaAdd_FormClosed;

                FaturaAdd.Dock = DockStyle.Fill;

                FaturaAdd.Show();

            }
            else
            {
                FaturaAdd.Activate();
            }
        }
        private void FaturaAdd_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FaturaAdd = null;

            LoadData();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücre tıklamadan dolayı olmayan hücrelerin tıklamalarını kontrol etmek için
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                int cellValue = (int)selectedCell.Value; // Tıklanan hücrenin değerini alın

                FaturaDetails info = new FaturaDetails(cellValue);
                info.Show();
                info.FormClosed += info_FormClosed;
                this.Dispose();
                info.Focus();

            }
        }

        private void info_FormClosed(object? sender, FormClosedEventArgs e)
        {



        }
    }
}
