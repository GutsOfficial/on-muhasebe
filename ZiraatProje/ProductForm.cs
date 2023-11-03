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
    public partial class ProductForm : Form
    {
        ZiraatContext context = new ZiraatContext();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Id"; // Sütunun adı
            column.Visible = false; // Sütunu gizle

            productData.Columns.Clear();
            productData.Columns.Add(column);

            productData.Columns.Add("name", "Ürün Adı");
            productData.Columns.Add("amount", "Amount");
            productData.Columns.Add("buyprice", "Alış Fiyatı");
            productData.Columns.Add("sellPrice", "Satış Fiyatı");

            var prudcts = context.ProductTypes.OrderByDescending(x => x.Date).ToList();
            foreach (var item in prudcts)
            {
                productData.Rows.Add(item.ProductName, item.Amount, item.SellPrice, item.Date, item.Date, item.Amount);
            }


        }
    }
}
