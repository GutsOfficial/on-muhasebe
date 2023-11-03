namespace ZiraatProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            sidebar = new System.Windows.Forms.Timer(components);
            faturaTimer = new System.Windows.Forms.Timer(components);
            giderTimer = new System.Windows.Forms.Timer(components);
            cashTimer = new System.Windows.Forms.Timer(components);
            durumpanel = new FlowLayoutPanel();
            panel3 = new Panel();
            label8 = new Label();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gelirpanel = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            panel6 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            giderpanel = new FlowLayoutPanel();
            panel4 = new Panel();
            label4 = new Label();
            bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            panel5 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            panel9 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            CashPanel = new FlowLayoutPanel();
            panel10 = new Panel();
            label9 = new Label();
            bunifuPictureBox4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            panel11 = new Panel();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            panel12 = new Panel();
            label11 = new Label();
            pictureBox7 = new PictureBox();
            durumpanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            gelirpanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            giderpanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            CashPanel.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox4).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1758, 68);
            panel1.TabIndex = 2;
            // 
            // sidebar
            // 
            sidebar.Tick += sidebar_Tick;
            // 
            // faturaTimer
            // 
            faturaTimer.Tick += faturaTimer_Tick;
            // 
            // giderTimer
            // 
            giderTimer.Tick += giderTimer_Tick;
            // 
            // cashTimer
            // 
            cashTimer.Tick += cashTimer_Tick;
            // 
            // durumpanel
            // 
            durumpanel.BackColor = Color.Transparent;
            durumpanel.Controls.Add(panel3);
            durumpanel.Location = new Point(3, 3);
            durumpanel.Name = "durumpanel";
            durumpanel.Size = new Size(295, 85);
            durumpanel.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(bunifuPictureBox1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 85);
            panel3.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(145, 158, 171);
            label8.Location = new Point(79, 32);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 5;
            label8.Text = "Güncel Durum";
            label8.Click += label8_Click;
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 0;
            bunifuPictureBox1.Image = (Image)resources.GetObject("bunifuPictureBox1.Image");
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(14, 19);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(46, 46);
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox1.TabIndex = 2;
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(durumpanel);
            flowLayoutPanel1.Controls.Add(gelirpanel);
            flowLayoutPanel1.Controls.Add(giderpanel);
            flowLayoutPanel1.Controls.Add(CashPanel);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(268, 715);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // gelirpanel
            // 
            gelirpanel.BackColor = Color.Transparent;
            gelirpanel.Controls.Add(panel2);
            gelirpanel.Controls.Add(panel6);
            gelirpanel.Controls.Add(panel7);
            gelirpanel.Location = new Point(3, 94);
            gelirpanel.Name = "gelirpanel";
            gelirpanel.Size = new Size(295, 85);
            gelirpanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(bunifuPictureBox2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 85);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(145, 158, 171);
            label2.Location = new Point(79, 32);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 5;
            label2.Text = "Gelirler";
            label2.Click += label2_Click_3;
            // 
            // bunifuPictureBox2
            // 
            bunifuPictureBox2.AllowFocused = false;
            bunifuPictureBox2.Anchor = AnchorStyles.None;
            bunifuPictureBox2.AutoSizeHeight = true;
            bunifuPictureBox2.BorderRadius = 23;
            bunifuPictureBox2.Image = (Image)resources.GetObject("bunifuPictureBox2.Image");
            bunifuPictureBox2.IsCircle = true;
            bunifuPictureBox2.Location = new Point(15, 19);
            bunifuPictureBox2.Name = "bunifuPictureBox2";
            bunifuPictureBox2.Size = new Size(46, 46);
            bunifuPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox2.TabIndex = 2;
            bunifuPictureBox2.TabStop = false;
            bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            bunifuPictureBox2.Click += label2_Click_3;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(3, 94);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 45);
            panel6.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(145, 158, 171);
            label3.Location = new Point(80, 13);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 6;
            label3.Text = "Faturalar";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += label3_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(3, 145);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 44);
            panel7.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(145, 158, 171);
            label1.Location = new Point(79, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 8;
            label1.Text = "Müşteriler";
            label1.Click += customerlbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += customerlbl_Click;
            // 
            // giderpanel
            // 
            giderpanel.BackColor = Color.Transparent;
            giderpanel.Controls.Add(panel4);
            giderpanel.Controls.Add(panel5);
            giderpanel.Controls.Add(panel8);
            giderpanel.Controls.Add(panel9);
            giderpanel.Location = new Point(3, 185);
            giderpanel.Name = "giderpanel";
            giderpanel.Size = new Size(295, 85);
            giderpanel.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(bunifuPictureBox3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 85);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(145, 158, 171);
            label4.Location = new Point(74, 34);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 5;
            label4.Text = "Giderler";
            label4.Click += label4_Click;
            // 
            // bunifuPictureBox3
            // 
            bunifuPictureBox3.AllowFocused = false;
            bunifuPictureBox3.Anchor = AnchorStyles.None;
            bunifuPictureBox3.AutoSizeHeight = true;
            bunifuPictureBox3.BorderRadius = 23;
            bunifuPictureBox3.Image = (Image)resources.GetObject("bunifuPictureBox3.Image");
            bunifuPictureBox3.IsCircle = true;
            bunifuPictureBox3.Location = new Point(15, 21);
            bunifuPictureBox3.Name = "bunifuPictureBox3";
            bunifuPictureBox3.Size = new Size(46, 46);
            bunifuPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox3.TabIndex = 2;
            bunifuPictureBox3.TabStop = false;
            bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            bunifuPictureBox3.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(3, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 47);
            panel5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(145, 158, 171);
            label5.Location = new Point(83, 15);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 6;
            label5.Text = "GiderBelgeleri";
            label5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += button5_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(label6);
            panel8.Controls.Add(pictureBox4);
            panel8.Location = new Point(3, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(252, 46);
            panel8.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(145, 158, 171);
            label6.Location = new Point(80, 17);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 8;
            label6.Text = "Tedarikçiler";
            label6.Click += Supplierbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(41, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += Supplierbtn_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label7);
            panel9.Controls.Add(pictureBox5);
            panel9.Location = new Point(3, 199);
            panel9.Name = "panel9";
            panel9.Size = new Size(252, 46);
            panel9.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(145, 158, 171);
            label7.Location = new Point(80, 17);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 8;
            label7.Text = "Çalışanlar";
            label7.Click += Employeebtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(41, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += Employeebtn_Click;
            // 
            // CashPanel
            // 
            CashPanel.BackColor = Color.Transparent;
            CashPanel.Controls.Add(panel10);
            CashPanel.Controls.Add(panel11);
            CashPanel.Controls.Add(panel12);
            CashPanel.Location = new Point(3, 276);
            CashPanel.Name = "CashPanel";
            CashPanel.Size = new Size(295, 85);
            CashPanel.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.Controls.Add(label9);
            panel10.Controls.Add(bunifuPictureBox4);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(252, 85);
            panel10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(145, 158, 171);
            label9.Location = new Point(79, 32);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 5;
            label9.Text = "Nakit";
            label9.Click += button9_Click;
            // 
            // bunifuPictureBox4
            // 
            bunifuPictureBox4.AllowFocused = false;
            bunifuPictureBox4.Anchor = AnchorStyles.None;
            bunifuPictureBox4.AutoSizeHeight = true;
            bunifuPictureBox4.BorderRadius = 0;
            bunifuPictureBox4.Image = (Image)resources.GetObject("bunifuPictureBox4.Image");
            bunifuPictureBox4.IsCircle = true;
            bunifuPictureBox4.Location = new Point(15, 18);
            bunifuPictureBox4.Name = "bunifuPictureBox4";
            bunifuPictureBox4.Size = new Size(46, 46);
            bunifuPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox4.TabIndex = 2;
            bunifuPictureBox4.TabStop = false;
            bunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            bunifuPictureBox4.Click += button9_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(label10);
            panel11.Controls.Add(pictureBox6);
            panel11.Location = new Point(3, 94);
            panel11.Name = "panel11";
            panel11.Size = new Size(252, 45);
            panel11.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(145, 158, 171);
            label10.Location = new Point(80, 13);
            label10.Name = "label10";
            label10.Size = new Size(135, 19);
            label10.TabIndex = 6;
            label10.Text = "Kasa ve Bankalar";
            label10.Click += cashAndBankbtn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(41, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += cashAndBankbtn_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(label11);
            panel12.Controls.Add(pictureBox7);
            panel12.Location = new Point(3, 145);
            panel12.Name = "panel12";
            panel12.Size = new Size(252, 44);
            panel12.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(145, 158, 171);
            label11.Location = new Point(79, 16);
            label11.Name = "label11";
            label11.Size = new Size(56, 19);
            label11.TabIndex = 8;
            label11.Text = "Çekler";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(40, 16);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 244);
            ClientSize = new Size(1758, 783);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            durumpanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            gelirpanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            giderpanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            CashPanel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox4).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private System.Windows.Forms.Timer sidebar;
        private System.Windows.Forms.Timer faturaTimer;
        private System.Windows.Forms.Timer giderTimer;
        private System.Windows.Forms.Timer cashTimer;
        private FlowLayoutPanel durumpanel;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private FlowLayoutPanel gelirpanel;
        private Panel panel2;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel giderpanel;
        private Panel panel4;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Panel panel5;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label3;
        private Panel panel9;
        private Label label7;
        private PictureBox pictureBox5;
        private FlowLayoutPanel CashPanel;
        private Panel panel10;
        private Label label9;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private Panel panel11;
        private Label label10;
        private PictureBox pictureBox6;
        private Panel panel12;
        private Label label11;
        private PictureBox pictureBox7;
    }
}