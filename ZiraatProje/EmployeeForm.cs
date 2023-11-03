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
    public partial class EmployeeForm : Form
    {
        AddEmployee AddEmployee;
        ZiraatContext context = new ZiraatContext();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (AddEmployee == null)
            {
                AddEmployee = new AddEmployee();
                AddEmployee.FormClosed += AddEmployee_FormClosed;

                AddEmployee.Dock = DockStyle.Fill;

                AddEmployee.Show();
            }
            else
            {
                AddEmployee.Activate();
            }
        }
        private void AddEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            AddEmployee = null;
            LoadData();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EmployeeData.BackgroundColor = Color.DarkRed;
        }
        private void LoadData()
        {
            EmployeeData.Columns.Clear();
            EmployeeData.Rows.Clear();
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.HeaderText = " ID"; // Sütun başlığı (gözükecek metin)
            column.Visible = false; // Sütunu gizle
            EmployeeData.Columns.Add(column);
            EmployeeData.Columns.Add("EmployeeName", "Çalışan Adı");
            EmployeeData.Columns.Add("entryDate", "İşe Giriş Tarihi");
            EmployeeData.Columns.Add("outDate", "İşten Çıkış Tarihi");
            EmployeeData.Columns.Add("number", "İletişim");
            EmployeeData.Columns.Add("balance", "Bakiye");
            foreach (var item in context.Employees.OrderByDescending(x => x.EntryDate).ToList())
            {
                EmployeeData.Rows.Add(item.EmployeeId, item.EmployeeName, item.EntryDate, item.ExitDate, item.PhoneNumber, item.Balance);

            }
        }

        private void EmployeeData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Hücre tıklamadan dolayı olmayan hücrelerin tıklamalarını kontrol etmek için
            {
                DataGridViewCell selectedCell = EmployeeData.Rows[e.RowIndex].Cells[0];
                int cellValue = (int)selectedCell.Value; // Tıklanan hücrenin değerini alın

                EmployeeInfo info = new EmployeeInfo(cellValue);
                info.Show();
                Close();
                info.Focus();

            }
        }
    }
}
