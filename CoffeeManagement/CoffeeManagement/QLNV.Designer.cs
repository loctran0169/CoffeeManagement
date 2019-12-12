namespace CoffeeManagement
{
    partial class QLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNV));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_name_nv = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.mavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name_nv
            // 
            this.tb_name_nv.AcceptsReturn = true;
            this.tb_name_nv.AcceptsTab = true;
            this.tb_name_nv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_name_nv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_name_nv.BackColor = System.Drawing.Color.Transparent;
            this.tb_name_nv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_name_nv.BackgroundImage")));
            this.tb_name_nv.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_name_nv.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_name_nv.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_name_nv.BorderColorIdle = System.Drawing.Color.DimGray;
            this.tb_name_nv.BorderRadius = 30;
            this.tb_name_nv.BorderThickness = 1;
            this.tb_name_nv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_name_nv.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_name_nv.HideSelection = true;
            this.tb_name_nv.IconLeft = null;
            this.tb_name_nv.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name_nv.IconPadding = 10;
            this.tb_name_nv.IconRight = ((System.Drawing.Image)(resources.GetObject("tb_name_nv.IconRight")));
            this.tb_name_nv.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name_nv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_name_nv.Location = new System.Drawing.Point(12, 29);
            this.tb_name_nv.MaximumSize = new System.Drawing.Size(400, 100);
            this.tb_name_nv.MaxLength = 32767;
            this.tb_name_nv.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_name_nv.Modified = false;
            this.tb_name_nv.Name = "tb_name_nv";
            this.tb_name_nv.PasswordChar = '\0';
            this.tb_name_nv.ReadOnly = false;
            this.tb_name_nv.SelectedText = "";
            this.tb_name_nv.SelectionLength = 0;
            this.tb_name_nv.SelectionStart = 0;
            this.tb_name_nv.ShortcutsEnabled = true;
            this.tb_name_nv.Size = new System.Drawing.Size(354, 35);
            this.tb_name_nv.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_name_nv.TabIndex = 1;
            this.tb_name_nv.TabStop = false;
            this.tb_name_nv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name_nv.TextMarginLeft = 5;
            this.tb_name_nv.TextPlaceholder = "Nhập tên hoặc mã  nhân viên...";
            this.tb_name_nv.UseSystemPasswordChar = false;
            this.tb_name_nv.OnIconRightClick += new System.EventHandler(this.tb_name_nv_OnIconRightClick);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Thêm nhân viên";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuButton1.IdleBorderRadius = 35;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(650, 29);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 0;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(161, 35);
            this.bunifuButton1.TabIndex = 3;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavn,
            this.tennv,
            this.ngaysinh,
            this.gioitinh,
            this.sdt});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "   ";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 96);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(831, 408);
            this.bunifuDataGridView1.TabIndex = 7;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            this.bunifuDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellDoubleClick);
            // 
            // mavn
            // 
            this.mavn.DataPropertyName = "manv";
            this.mavn.HeaderText = "Mã nhân viên";
            this.mavn.Name = "mavn";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.tb_name_nv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLNV";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_name_nv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}