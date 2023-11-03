using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using ZiraatProje.Models.Products;

namespace ZiraatProje
{
    public partial class FaturaAdd : Form
    {
        Form1 form1 = new Form1();
        ZiraatContext context = new ZiraatContext();
        FaturaDashboard dashboard = new FaturaDashboard();
        public FaturaAdd()
        {
            InitializeComponent();
        }
        int type = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                var customer = context.Customers.FirstOrDefault(c => c.CustomerFullName == CustomerNameTbx.Text);
                if (customer == null)
                {

                    customer = new Customer
                    {

                        CustomerFullName = CustomerNameTbx.Text,

                    };
                    context.Customers.Add(customer);
                }
                else
                {
                    if (customer.Balance < 0)
                    {
                        customer.Balance += (float)Convert.ToDouble(geneltoplamlbl.Text);

                        if (customer.Balance > 0)
                        {
                            // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                            this.Invoke((MethodInvoker)delegate
                            {
                                geneltoplamlbl.Text = customer.Balance.ToString();
                            });
                            customer.Balance = 0;
                        }
                        else
                        {
                            // UI elemanına erişim, Invoke ile ana iş parçacığına aktarılmalı
                            this.Invoke((MethodInvoker)delegate
                            {
                                geneltoplamlbl.Text = "0";
                            });
                        }
                        context.Customers.Update(customer);
                    }

                }

                ProductType product1;
                var modelProduct = context.ProductTypes.FirstOrDefault(x => x.ProductName == ProductNametbx.Text);
                if (modelProduct == null)
                {
                    product1 = new ProductType
                    {
                        ProductName = ProductNametbx.Text,
                        Stock = 0 - (float)Convert.ToDouble(Amounttbx.Text),
                        Amount = (float)Convert.ToDouble(Amounttbx.Text),
                        Unit = Unittbx.Text,
                        SellPrice = (float)Convert.ToDouble(UnitPricetbx.Text),
                        KDV = (float)Convert.ToDouble(KDVtbx.Text),

                    };
                }
                else
                {
                    product1 = modelProduct;
                    product1.Stock = modelProduct.Stock - (float)Convert.ToDouble(Amounttbx.Text);
                }

                var invoice = new Invoice
                {
                    InvoiceName = InvoiceNametbx.Text,
                    CustomerInfo = customer,
                    InvoiceDate = InvoiceDatepicker.Value,
                    InvoiceSerialNo = Convert.ToInt32(InvoiceSerialNumbertbx.Text),
                    InvoiceSuquenceNo = Convert.ToInt32(InvoiceSuquenceNotbx.Text),
                    IsPaid = IsPaidcbx.Checked,
                    CurrencyType = type,
                    PaymentDate = (IsPaidcbx.Checked == false) ? VadeDate.Value : DateTime.Now,
                    Total = (float)Convert.ToDouble(geneltoplamlbl.Text),
                    LastTotal = (float)Convert.ToDouble(geneltoplamlbl.Text),

                };
                invoice.InvoiceProductTypes = new List<InvoiceProductType>
                    {
    new InvoiceProductType { ProductType = product1 },

};
                context.Invoices.Add(invoice);
                context.SaveChanges();
            });

            MessageBox.Show("İşlem tamamlandı.");
            this.Close();

        }


        private void FaturaAdd_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnitPricetbx_TextChanged(object sender, EventArgs e)
        {
            if (UnitPricetbx.Text != "" && Amounttbx.Text != "" && KDVtbx.Text != "")
            {
                float total = (float)Convert.ToDouble(Amounttbx.Text) * (float)Convert.ToDouble(UnitPricetbx.Text);


                float yuzdeYirmi = total * Convert.ToInt32(KDVtbx.Text) / 100.0f;
                aratoplamlbl.Text = total.ToString();
                // Toplamı yüzde 20 ile artırın
                total += yuzdeYirmi;
                toplamKDVlbl.Text = Convert.ToString(total - Convert.ToDouble(aratoplamlbl.Text));
                // Sonucu Totaltbx TextBox'ına yazdırın
                Totaltbx.Text = Convert.ToString(total);
                geneltoplamlbl.Text = total.ToString();
            }
        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameTbx_TextChanged(object sender, EventArgs e)
        {
            var filteredCustomers = context.Customers
        .Where(c => c.CustomerFullName.Contains(CustomerNameTbx.Text))
        .Select(c => new { c.CustomerFullName }) // Yalnızca CustomerFullName sütununu seç
        .ToList();

            müsteridatagrid.DataSource = filteredCustomers;
        }

        private void müsteridatagrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void müsteridatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            string deger = müsteridatagrid.Rows[row].Cells[column].Value.ToString();
            CustomerNameTbx.Text = deger;
        }

        private void t(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Refresh();
        }

        private void ProductNametbx_TextChanged(object sender, EventArgs e)
        {
            if (ProductNametbx.Text != "")
            {

                foreach (var item in context.ProductTypes.Where(x => x.ProductName.Contains(ProductNametbx.Text)))
                {
                    productcbx.Items.Add(item.ProductName);
                }
            }
        }

        private void productcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = context.ProductTypes.FirstOrDefault(x => x.ProductName == productcbx.SelectedItem);
            if (product != null)
            {
                ProductNametbx.Text = product.ProductName;
                Amounttbx.Text = product.Amount.ToString();
                Unittbx.Text = product.Unit;
                UnitPricetbx.Text = product.SellPrice.ToString();

            }
        }

        private void Amounttbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void UnitPricetbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
