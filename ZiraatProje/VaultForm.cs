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
    public partial class VaultForm : Form
    {
        ZiraatContext context = new ZiraatContext();
        public VaultForm()
        {
            InitializeComponent();
        }
        AddVault AddVault;
        private void button1_Click(object sender, EventArgs e)
        {
            if (AddVault == null)
            {
                AddVault = new AddVault();
                AddVault.FormClosed += AddVault_FormClosed;

                AddVault.Dock = DockStyle.Fill;

                AddVault.Show();
            }
            else
            {
                AddVault.Activate();
            }
        }

        private void AddVault_FormClosed(object? sender, FormClosedEventArgs e)
        {
            AddVault = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VaultForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            VaultData.Columns.Clear();
            VaultData.Columns.Add("vaultName", "Hesap Adı");
            VaultData.Columns.Add("iban", "IBAN");
            VaultData.Columns.Add("currency", "Döviz Cinsi");
            VaultData.Columns.Add("balance", "Bakiye");
            foreach (var item in context.Vaults.OrderByDescending(x => x.OpenDate).ToList())
            {
                VaultData.Rows.Add(item.VaultName, "-", item.CurrencyType, item.Balance);

            }
        }
    }
}
