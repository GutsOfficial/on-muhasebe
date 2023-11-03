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
    public partial class GiderForm : Form
    {
        ZiraatContext context = new ZiraatContext();
        AddReceipt AddReceipt;
        public GiderForm()
        {
            InitializeComponent();
        }

        private void GiderForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.Visible = false; // Sütunu gizle
            var column2 = new DataGridViewTextBoxColumn();
            column2.Name = "ispaid"; // Sütunun adı
            column2.Visible = false; // Sütunu gizle
            FisData.Columns.Clear();
            FisData.Columns.Add(column2);
            FisData.Columns.Add(column);

            FisData.Columns.Add("bilgi", "Bilgi / Açıklama");
            FisData.Columns.Add("Date", "Düzenlenme Tarihi");
            FisData.Columns.Add("vadeDate", "Vade Tarihi");
            FisData.Columns.Add("belgetotal", "Belge Tutarı");

            var receipts = context.Receipts.OrderByDescending(x => x.PaymentDate).ToList();
            foreach (var item in receipts)
            {
                FisData.Rows.Add(item.IsPaid, item.ReceiptId, item.ReceiptName, item.Date, item.PaymentDate, item.Amount);
            }

            foreach (DataGridViewRow row in FisData.Rows)
            {
                if (row.Cells["vadeDate"].Value != null && row.Cells["ispaid"].Value != null)
                {
                    DateTime vadeTarihi = Convert.ToDateTime(row.Cells["vadeDate"].Value);
                    bool ispaid = (bool)row.Cells["ispaid"].Value;
                    if (vadeTarihi < DateTime.Today && !ispaid)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.Red;
                            cell.Style.ForeColor = Color.White;
                        }
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddReceipt == null)
            {
                AddReceipt = new AddReceipt();
                AddReceipt.FormClosed += AddReceipt_FormClosed;

                AddReceipt.Dock = DockStyle.Fill;

                AddReceipt.Show();
            }
            else
            {
                AddReceipt.Activate();
            }
        }
        private void AddReceipt_FormClosed(object? sender, FormClosedEventArgs e)
        {
            AddReceipt = null;

            LoadData();

        }

        private void FisData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücre tıklamadan dolayı olmayan hücrelerin tıklamalarını kontrol etmek için
            {
                DataGridViewCell selectedCell = FisData.Rows[e.RowIndex].Cells[1];
                int id = (int)selectedCell.Value; // Tıklanan hücrenin değerini alın

                FaturaDetails info = new FaturaDetails(id);
                info.Show();
            }
        }
    }

}
