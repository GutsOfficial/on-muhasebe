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
    public partial class ReceiptInfo : Form
    {
        ZiraatContext context = new ZiraatContext();
        int deger;
        public ReceiptInfo(int id)
        {
            deger = id;
            InitializeComponent();
        }

        private void ReceiptInfo_Load(object sender, EventArgs e)
        {
            if (deger != 0)
            {
                var receipt = context.Receipts.Include(x => x.ExpenseType).FirstOrDefault(x => x.ReceiptId == deger);
                if (receipt != null)
                {

                    if (receipt.IsPaid == true)
                    {
                        ispaidPanel.Visible = true;
                        button4.Enabled = false;
                    }

                    aratoplamlbl.Text = receipt.Amount.ToString();
                    toplamKDVlbl.Text = receipt.KDVAmount.ToString();
                    LastTotallbl.Text = receipt.LastTotal.ToString();
                    geneltoplamlbl.Text = (receipt.Amount + receipt.KDVAmount).ToString();
                    ReceiptNamelbl.Text = receipt.ReceiptName;

                    ReceiptDate.Text = receipt.Date.ToString();
                    var supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == receipt.SupplierId);
                    if (supplier != null)
                    {
                        SupplierNamelbl.Text = supplier.SupplierName;

                    }
                    if (receipt.PaymentType == 0)
                    {
                        PaymentTypelbl.Text = $"{"Vadeli"} / {receipt.PaymentDate}";
                    }
                    else
                    {
                        PaymentTypelbl.Text = $"{"Peşin"} / {receipt.PaymentDate}";

                    }
                    ReceiptNolbl.Text = receipt.ReceiptNo.ToString();
                    ExpenseType.Text = receipt.ExpenseType.ExpenseName != null ? receipt.ExpenseType.ExpenseName : "-";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceiptPayment payment = new ReceiptPayment(deger);
            payment.Show();
        }
    }
}
