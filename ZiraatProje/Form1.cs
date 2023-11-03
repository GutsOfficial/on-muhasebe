using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.WinForms.RichTextEditor.ColorEditor.ColorSchemas;

namespace ZiraatProje
{
    public partial class Form1 : Form
    {
        FaturaAdd? FaturaAdd;
        UIForm? FaturaDashboard;
        CustomerForm? CustomerForm;
        GiderForm? GiderForm;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FaturaDashboard != null)
            {
                FaturaDashboard.Dispose();

            }
            FaturaDashboard = new UIForm();

            FaturaDashboard.FormClosed += FaturaDashboard_FormClosed;
            FaturaDashboard.MdiParent = this;
            FaturaDashboard.Dock = DockStyle.Fill;
            FaturaDashboard.Show();
        }

        private void FaturaDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FaturaDashboard = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();

        }


        bool sidebarExpand = true;

        private void sidebar_Tick(object sender, EventArgs e)
        {
            //if (sidebarExpand)
            //{
            //    sidebarPanel.Width -= 90;
            //    if (sidebarPanel.Width <= 71)
            //    {
            //        sidebarExpand = false;
            //        sidebar.Stop();
            //    }
            //}
            //else
            //{
            //    sidebarPanel.Width += 90;
            //    if (sidebarPanel.Width >= 160)
            //    {
            //        sidebarExpand = true;
            //        sidebar.Stop();
            //    }
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }
        bool menuExpand = false;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void faturaTimer_Tick(object sender, EventArgs e)
        {
            faturaTimer.Interval = 10;
            if (menuExpand == false)
            {
                gelirpanel.Height += 15;
                if (gelirpanel.Height >= 187)
                {
                    faturaTimer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                gelirpanel.Height -= 15;
                if (gelirpanel.Height <= 85)
                {
                    faturaTimer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CustomerForm = null;
        }
        bool giderExpand = false;
        private void giderTimer_Tick(object sender, EventArgs e)
        {
            giderTimer.Interval = 10;

            if (giderExpand == false)
            {
                giderpanel.Height += 16;
                if (giderpanel.Height >= 250)
                {
                    giderTimer.Stop();
                    giderExpand = true;
                }
            }
            else
            {
                giderpanel.Height -= 15;
                if (giderpanel.Height <= 85)
                {
                    giderTimer.Stop();
                    giderExpand = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giderTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GiderForm != null)
            {
                GiderForm.Dispose();

            }
            GiderForm = new GiderForm();
            GiderForm.FormClosed += GiderForm_FormClosed;
            GiderForm.MdiParent = this;
            GiderForm.Dock = DockStyle.Fill;
            GiderForm.Show();
        }

        private void GiderForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GiderForm = null;
        }
        SupplierForm supplierForm;
        private void Supplierbtn_Click(object sender, EventArgs e)
        {
            if (supplierForm == null || supplierForm.IsDisposed)
            {
                supplierForm = new SupplierForm();
                supplierForm.FormClosed += supplierForm_FormClosed;
                supplierForm.MdiParent = this;
                supplierForm.Dock = DockStyle.Fill;
                supplierForm.Show();
            }
            else
            {
                supplierForm.Activate();
            }
        }
        private void supplierForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            GiderForm = null;
        }
        EmployeeForm employeeForm;
        private void Employeebtn_Click(object sender, EventArgs e)
        {
            if (employeeForm == null || employeeForm.IsDisposed)
            {
                employeeForm = new EmployeeForm();
                employeeForm.FormClosed += employeeForm_FormClosed;
                employeeForm.MdiParent = this;
                employeeForm.Dock = DockStyle.Fill;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }
        private void employeeForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            employeeForm = null;
        }
        bool cashExpend = false;
        private void cashTimer_Tick(object sender, EventArgs e)
        {
            cashTimer.Interval = 10;

            if (cashExpend == false)
            {
                CashPanel.Height += 15;
                if (CashPanel.Height >= 196)
                {
                    cashTimer.Stop();
                    cashExpend = true;
                }
            }
            else
            {
                CashPanel.Height -= 15;
                if (CashPanel.Height <= 85)
                {
                    cashTimer.Stop();
                    cashExpend = false;
                }
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            cashTimer.Start();
        }
        VaultForm VaultForm;
        private void cashAndBankbtn_Click(object sender, EventArgs e)
        {
            if (VaultForm == null || VaultForm.IsDisposed)
            {
                VaultForm = new VaultForm();
                VaultForm.FormClosed += VaultForm_FormClosed;
                VaultForm.MdiParent = this;
                VaultForm.Dock = DockStyle.Fill;
                VaultForm.Show();
            }
            else
            {
                VaultForm.Activate();
            }
        }

        private void VaultForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            VaultForm = null;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }
        FaturaDashboard fatura;
        bool color = false;
        private void label3_Click(object sender, EventArgs e)
        {
            fatura = new FaturaDashboard();

            if (fatura != null)
            {
                fatura.Dispose();

            }
            fatura = new FaturaDashboard();

            fatura.FormClosed += Fatura_FormClosed;
            fatura.MdiParent = this;
            fatura.Dock = DockStyle.Fill;
            fatura.Show();
            color = true;
            fatura.FormClosed += Fatura_FormClosed;

        }

        private void Fatura_FormClosed(object? sender, FormClosedEventArgs e)
        {
            color = false;

            fatura = null;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }





        private void durumpanel_MouseEnter(object sender, EventArgs e)
        {
            durumpanel.BackColor = Color.WhiteSmoke;

        }

        private void durumpanel_MouseLeave(object sender, EventArgs e)
        {
            durumpanel.BackColor = Color.White;
        }

        private void customerlbl_Click(object sender, EventArgs e)
        {
            if (CustomerForm != null)
            {
                CustomerForm.Dispose();

            }
            CustomerForm = new CustomerForm();

            CustomerForm.FormClosed += CustomerForm_FormClosed;
            CustomerForm.MdiParent = this;
            CustomerForm.Dock = DockStyle.Fill;
            CustomerForm.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void gelirpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            faturaTimer.Start();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {
            faturaTimer.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            giderTimer.Start();
        }
    }
}