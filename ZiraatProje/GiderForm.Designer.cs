namespace ZiraatProje
{
    partial class GiderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            label25 = new Label();
            bunifuShadowPanel3 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            FisData = new Bunifu.UI.WinForms.BunifuDataGridView();
            bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            bunifuShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FisData).BeginInit();
            SuspendLayout();
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
            button1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.IdleBorderThickness = 1;
            button1.IdleCornerRadius = 20;
            button1.IdleFillColor = Color.FromArgb(249, 159, 122);
            button1.IdleForecolor = Color.White;
            button1.IdleLineColor = Color.FromArgb(249, 159, 122);
            button1.Location = new Point(1036, 30);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(121, 46);
            button1.TabIndex = 45;
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Click += button1_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Roboto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(31, 30);
            label25.Name = "label25";
            label25.Size = new Size(112, 33);
            label25.TabIndex = 46;
            label25.Text = "Giderler";
            // 
            // bunifuShadowPanel3
            // 
            bunifuShadowPanel3.BackColor = Color.Transparent;
            bunifuShadowPanel3.BorderColor = Color.Transparent;
            bunifuShadowPanel3.BorderRadius = 15;
            bunifuShadowPanel3.BorderThickness = 1;
            bunifuShadowPanel3.Controls.Add(FisData);
            bunifuShadowPanel3.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel3.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel3.Location = new Point(40, 126);
            bunifuShadowPanel3.Name = "bunifuShadowPanel3";
            bunifuShadowPanel3.PanelColor = Color.White;
            bunifuShadowPanel3.PanelColor2 = Color.White;
            bunifuShadowPanel3.ShadowColor = Color.Silver;
            bunifuShadowPanel3.ShadowDept = 2;
            bunifuShadowPanel3.ShadowDepth = 10;
            bunifuShadowPanel3.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel3.ShadowTopLeftVisible = false;
            bunifuShadowPanel3.Size = new Size(1193, 523);
            bunifuShadowPanel3.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel3.TabIndex = 47;
            // 
            // FisData
            // 
            FisData.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            FisData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            FisData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FisData.BorderStyle = BorderStyle.None;
            FisData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FisData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FisData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FisData.ColumnHeadersHeight = 40;
            FisData.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            FisData.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FisData.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            FisData.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            FisData.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            FisData.CurrentTheme.BackColor = Color.White;
            FisData.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            FisData.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            FisData.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
            FisData.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            FisData.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            FisData.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            FisData.CurrentTheme.Name = null;
            FisData.CurrentTheme.RowsStyle.BackColor = Color.White;
            FisData.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FisData.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            FisData.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            FisData.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            FisData.DefaultCellStyle = dataGridViewCellStyle3;
            FisData.EnableHeadersVisualStyles = false;
            FisData.GridColor = Color.FromArgb(221, 238, 255);
            FisData.HeaderBackColor = Color.DodgerBlue;
            FisData.HeaderBgColor = Color.Empty;
            FisData.HeaderForeColor = Color.White;
            FisData.Location = new Point(58, 83);
            FisData.Name = "FisData";
            FisData.RowHeadersVisible = false;
            FisData.RowTemplate.Height = 40;
            FisData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FisData.Size = new Size(1078, 393);
            FisData.TabIndex = 1;
            FisData.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            FisData.CellDoubleClick += FisData_CellDoubleClick;
            // 
            // bunifuDropdown1
            // 
            bunifuDropdown1.BackColor = Color.Transparent;
            bunifuDropdown1.BackgroundColor = Color.White;
            bunifuDropdown1.BorderColor = Color.Silver;
            bunifuDropdown1.BorderRadius = 10;
            bunifuDropdown1.Color = Color.Silver;
            bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            bunifuDropdown1.DisabledBackColor = Color.FromArgb(240, 240, 240);
            bunifuDropdown1.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            bunifuDropdown1.DisabledColor = Color.FromArgb(240, 240, 240);
            bunifuDropdown1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            bunifuDropdown1.DisabledIndicatorColor = Color.DarkGray;
            bunifuDropdown1.DrawMode = DrawMode.OwnerDrawFixed;
            bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            bunifuDropdown1.DropDownStyle = ComboBoxStyle.DropDownList;
            bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            bunifuDropdown1.FillDropDown = true;
            bunifuDropdown1.FillIndicator = false;
            bunifuDropdown1.FlatStyle = FlatStyle.Flat;
            bunifuDropdown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuDropdown1.ForeColor = Color.Black;
            bunifuDropdown1.FormattingEnabled = true;
            bunifuDropdown1.Icon = null;
            bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            bunifuDropdown1.IndicatorColor = Color.DarkGray;
            bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            bunifuDropdown1.IndicatorThickness = 2;
            bunifuDropdown1.IsDropdownOpened = false;
            bunifuDropdown1.ItemBackColor = Color.White;
            bunifuDropdown1.ItemBorderColor = Color.White;
            bunifuDropdown1.ItemForeColor = Color.Black;
            bunifuDropdown1.ItemHeight = 26;
            bunifuDropdown1.ItemHighLightColor = Color.DodgerBlue;
            bunifuDropdown1.ItemHighLightForeColor = Color.White;
            bunifuDropdown1.ItemTopMargin = 3;
            bunifuDropdown1.Location = new Point(872, 36);
            bunifuDropdown1.Name = "bunifuDropdown1";
            bunifuDropdown1.Size = new Size(138, 32);
            bunifuDropdown1.TabIndex = 48;
            bunifuDropdown1.Text = "Diğer";
            bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            bunifuDropdown1.TextLeftMargin = 5;
            // 
            // GiderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 244);
            ClientSize = new Size(1254, 684);
            Controls.Add(bunifuDropdown1);
            Controls.Add(bunifuShadowPanel3);
            Controls.Add(label25);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiderForm";
            Text = "GiderForm";
            Load += GiderForm_Load;
            bunifuShadowPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FisData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private Label label25;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel3;
        private Bunifu.UI.WinForms.BunifuDataGridView FisData;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
    }
}