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
    public partial class AddCustomer : Form
    {
        ZiraatContext context = new ZiraatContext();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerFullName = SupplierNametbx.Text,
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
            context.Customers.Add(customer);
            context.SaveChanges();
            MessageBox.Show("İşlem tamam");
            this.Close();
        }
    }
}
