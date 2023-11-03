namespace ZiraatProje
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            label2 = new Label();
            EmployeeData = new Bunifu.UI.WinForms.BunifuDataGridView();
            button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)EmployeeData).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 20;
            label2.Text = "Çalışanlar";
            // 
            // EmployeeData
            // 
            EmployeeData.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            EmployeeData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            EmployeeData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeData.BorderStyle = BorderStyle.None;
            EmployeeData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeeData.ColumnHeadersHeight = 40;
            EmployeeData.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            EmployeeData.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeData.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            EmployeeData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            EmployeeData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            EmployeeData.CurrentTheme.BackColor = Color.White;
            EmployeeData.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            EmployeeData.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            EmployeeData.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeData.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            EmployeeData.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            EmployeeData.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            EmployeeData.CurrentTheme.Name = null;
            EmployeeData.CurrentTheme.RowsStyle.BackColor = Color.White;
            EmployeeData.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeData.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            EmployeeData.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            EmployeeData.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeeData.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeeData.EnableHeadersVisualStyles = false;
            EmployeeData.GridColor = Color.FromArgb(221, 238, 255);
            EmployeeData.HeaderBackColor = Color.DodgerBlue;
            EmployeeData.HeaderBgColor = Color.Empty;
            EmployeeData.HeaderForeColor = Color.White;
            EmployeeData.Location = new Point(50, 155);
            EmployeeData.Name = "EmployeeData";
            EmployeeData.RowHeadersVisible = false;
            EmployeeData.RowTemplate.Height = 40;
            EmployeeData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeData.Size = new Size(1042, 374);
            EmployeeData.TabIndex = 22;
            EmployeeData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            EmployeeData.CellDoubleClick += EmployeeData_CellDoubleClick;
            // 
            // button1
            // 
            button1.ActiveBorderThickness = 1;
            button1.ActiveCornerRadius = 20;
            button1.ActiveFillColor = Color.FromArgb(249, 159, 122);
            button1.ActiveForecolor = Color.FromArgb(249, 159, 122);
            button1.ActiveLineColor = Color.FromArgb(249, 159, 122);
            button1.BackColor = Color.FromArgb(236, 240, 244);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.ButtonText = "Fatura Ekle";
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.IdleBorderThickness = 1;
            button1.IdleCornerRadius = 20;
            button1.IdleFillColor = Color.FromArgb(249, 159, 122);
            button1.IdleForecolor = Color.White;
            button1.IdleLineColor = Color.FromArgb(249, 159, 122);
            button1.Location = new Point(1022, 20);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(121, 48);
            button1.TabIndex = 38;
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Click += button1_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 244);
            ClientSize = new Size(1209, 589);
            Controls.Add(button1);
            Controls.Add(EmployeeData);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView EmployeeData;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
    }
}