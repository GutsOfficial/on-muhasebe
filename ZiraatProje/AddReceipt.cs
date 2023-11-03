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
using ZiraatProje.Models.Giderler;

namespace ZiraatProje
{
    public partial class AddReceipt : Form
    {
        ZiraatContext context = new ZiraatContext();
        public AddReceipt()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddReceiptbtn_Click(object sender, EventArgs e)
        {
            var Supplier = context.Suppliers.FirstOrDefault(x => x.SupplierName == SupplierNametbx.Text);
            if (Supplier == null)
            {
                Supplier = new Supplier
                {
                    SupplierName = SupplierNametbx.Text,


                };
                context.Suppliers.Add(Supplier);

            }
            else
            {
                Supplier.SupplierName = SupplierNametbx.Text;
                if (Supplier.Balance > 0)
                {
                    Supplier.Balance -= (float)Convert.ToDouble(geneltoplamlbl.Text);

                    if (Supplier.Balance > 0)
                    {
                        // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                        this.Invoke((MethodInvoker)delegate
                        {
                            geneltoplamlbl.Text = "0";
                        });

                    }
                    else
                    {
                        // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                        this.Invoke((MethodInvoker)delegate
                        {
                            geneltoplamlbl.Text = (Supplier.Balance * -1).ToString();
                            Supplier.Balance = 0;
                        });
                    }
                    context.Suppliers.Update(Supplier);
                }
            }
            var expense = context.ExpenseTypes.FirstOrDefault(x => x.ExpenseName == ExpenseNametbx.Text);
            if (expense == null)
            {
                expense = new ExpenseType
                {
                    ExpenseName = ExpenseNametbx.Text,

                };
            }
            else
            {
                expense.ExpenseName = ExpenseNametbx.Text;
            }
            int payment;
            if (vaderbtn.Checked)
            {
                payment = 0;

            }
            else
            {
                payment = 1;
            }
            Receipt receipt;
            if (pesinrbtn.Checked)
            {
                receipt = new Receipt()
                {
                    ReceiptName = ReceiptNametbx.Text,
                    Supplier = Supplier,
                    ExpenseType = expense,
                    ReceiptNo = Convert.ToInt32(ReceiptNotbx.Text),
                    Date = ReceiptDate.Value,
                    Amount = (float)Convert.ToDouble(Amounttbx.Text),
                    KDV = (float)Convert.ToDouble(KDV.Text),
                    KDVAmount = (float)Convert.ToDouble(KDVTotal.Text),
                    IsPaid = true,
                    Total = 0,
                    LastTotal = 0,
                    PaymentType = payment,

                    PaymentDate = pesinDate.Value,

                };
                var vault = context.Vaults.FirstOrDefault(x => x.VaultName == comboBox1.SelectedItem.ToString());
                if (vault != null)
                {
                    vault.Balance -= (float)Convert.ToDouble(Amounttbx.Text) + (float)Convert.ToDouble(KDVTotal.Text);
                    context.Vaults.Update(vault);

                }
            }
            else
            {
                receipt = new Receipt()
                {
                    ReceiptName = ReceiptNametbx.Text,
                    Supplier = Supplier,
                    ExpenseType = expense,
                    ReceiptNo = Convert.ToInt32(ReceiptNotbx.Text),
                    Date = ReceiptDate.Value,
                    Amount = (float)Convert.ToDouble(Amounttbx.Text),
                    KDV = (float)Convert.ToDouble(KDV.Text),
                    KDVAmount = (float)Convert.ToDouble(KDVTotal.Text),
                    IsPaid = false,
                    Total = (float)Convert.ToDouble(geneltoplamlbl.Text),
                    LastTotal = (float)Convert.ToDouble(geneltoplamlbl.Text),
                    PaymentType = payment,
                    PaymentDate = PaymentDate.Value,

                };
            }
            context.Receipts.Add(receipt);
            context.SaveChanges();
            MessageBox.Show("işlem tamam");
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Amounttbx_TextChanged(object sender, EventArgs e)
        {

            if (Amounttbx.Text != "" && KDV.Text != "")
            {
                float yuzdeYirmi = (float)Convert.ToDouble(Amounttbx.Text) * (float)Convert.ToDouble(KDV.Text) / 100.0f;
                KDVTotal.Text = yuzdeYirmi.ToString();
                geneltoplamlbl.Text = ((float)Convert.ToDouble(Amounttbx.Text) + yuzdeYirmi).ToString();
            }

        }

        private void Amounttbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void ReceiptNotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void KDVTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void SupplierNametbx_TextChanged(object sender, EventArgs e)
        {
            if (SupplierNametbx.Text != "")
            {
                suppliercbx.Items.Clear();
                foreach (var item in context.Suppliers.Where(x => x.SupplierName.Contains(SupplierNametbx.Text)))
                {
                    suppliercbx.Items.Add(item.SupplierName);
                }
                suppliercbx.DroppedDown = true;

            }
        }

        private void suppliercbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var supplier = context.Suppliers.FirstOrDefault(x => x.SupplierName == suppliercbx.SelectedItem);
            if (supplier != null)
            {
                SupplierNametbx.Text = supplier.SupplierName;

            }
        }

        private void SupplierNametbx_Leave(object sender, EventArgs e)
        {
        }

        private void pesinrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pesinrbtn.Checked)
            {
                vadepanel.Visible = false;
                pesinpanel.Visible = true;
                var firstItem = context.Vaults.FirstOrDefault(x => x.VaultId == 1);

                if (firstItem != null)
                {
                    // ComboBox'a ilk öğeyi ekleyin ve seçili yapın
                    comboBox1.Items.Add(firstItem.VaultName);
                    comboBox1.SelectedItem = firstItem.VaultName;

                    // Diğer öğeleri işlemek için ayrı bir döngü veya LINQ kullanabilirsiniz
                    foreach (var item in context.Vaults.Skip(1))
                    {
                        comboBox1.Items.Add(item.VaultName);
                    }
                }
            }
            else
            {
                pesinpanel.Visible = false;
                vadepanel.Visible = true;
            }
        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
