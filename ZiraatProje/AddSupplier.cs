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
    public partial class AddSupplier : Form
    {
        ZiraatContext context = new ZiraatContext();
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier()
            {
                SupplierName = SupplierNametbx.Text,
                NickName = SupplierNickNametbx.Text,
                Email = SupplierMailtbx.Text,
                PhoneNumber = Phonenumbertbx.Text,
                Address = Addresstbx.Text,
                City = Citytbx.Text,
                District = ilcetbx.Text,
                IsTuzel = (tuzelrbtn.Checked) ? true : false,
                TC = TCtbx.Text,
                VergiDairesi = vergiNotbx.Text,
                PaymentAccount = IBANtbx.Text,
            };
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            MessageBox.Show("İşlem tamam");
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
