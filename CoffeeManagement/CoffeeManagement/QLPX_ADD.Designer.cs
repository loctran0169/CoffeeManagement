namespace CoffeeManagement
{
    partial class QLPX_ADD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPX_ADD));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_diachi = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tb_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.date_ngayxuat = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgv_ct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_lappx = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbb = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tb_soluong = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_in = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 39);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton1.Image = global::CoffeeManagement.Properties.Resources.left_arrow_1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 48;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(40, 8);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel5.TabIndex = 49;
            this.bunifuCustomLabel5.Text = "Lập phiếu xuất";
            // 
            // tb_diachi
            // 
            this.tb_diachi.AcceptsReturn = false;
            this.tb_diachi.AcceptsTab = false;
            this.tb_diachi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_diachi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_diachi.BackColor = System.Drawing.Color.White;
            this.tb_diachi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_diachi.BackgroundImage")));
            this.tb_diachi.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.tb_diachi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_diachi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.tb_diachi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.tb_diachi.BorderRadius = 15;
            this.tb_diachi.BorderThickness = 1;
            this.tb_diachi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_diachi.FillColor = System.Drawing.Color.White;
            this.tb_diachi.HideSelection = true;
            this.tb_diachi.IconLeft = null;
            this.tb_diachi.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_diachi.IconPadding = 10;
            this.tb_diachi.IconRight = null;
            this.tb_diachi.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_diachi.Location = new System.Drawing.Point(240, 62);
            this.tb_diachi.MaximumSize = new System.Drawing.Size(400, 100);
            this.tb_diachi.MaxLength = 32767;
            this.tb_diachi.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_diachi.Modified = false;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.PasswordChar = '\0';
            this.tb_diachi.ReadOnly = false;
            this.tb_diachi.SelectedText = "";
            this.tb_diachi.SelectionLength = 0;
            this.tb_diachi.SelectionStart = 0;
            this.tb_diachi.ShortcutsEnabled = true;
            this.tb_diachi.Size = new System.Drawing.Size(270, 35);
            this.tb_diachi.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_diachi.TabIndex = 0;
            this.tb_diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_diachi.TextMarginLeft = 5;
            this.tb_diachi.TextPlaceholder = "Địa chỉ đến";
            this.tb_diachi.UseSystemPasswordChar = false;
            // 
            // tb_name
            // 
            this.tb_name.AcceptsReturn = false;
            this.tb_name.AcceptsTab = false;
            this.tb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_name.BackColor = System.Drawing.Color.Transparent;
            this.tb_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_name.BackgroundImage")));
            this.tb_name.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_name.BorderColorIdle = System.Drawing.Color.DimGray;
            this.tb_name.BorderRadius = 15;
            this.tb_name.BorderThickness = 1;
            this.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_name.Enabled = false;
            this.tb_name.FillColor = System.Drawing.Color.White;
            this.tb_name.HideSelection = true;
            this.tb_name.IconLeft = null;
            this.tb_name.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.IconPadding = 10;
            this.tb_name.IconRight = null;
            this.tb_name.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.Location = new System.Drawing.Point(22, 62);
            this.tb_name.MaximumSize = new System.Drawing.Size(400, 100);
            this.tb_name.MaxLength = 32767;
            this.tb_name.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_name.Modified = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.ReadOnly = false;
            this.tb_name.SelectedText = "";
            this.tb_name.SelectionLength = 0;
            this.tb_name.SelectionStart = 0;
            this.tb_name.ShortcutsEnabled = false;
            this.tb_name.Size = new System.Drawing.Size(190, 35);
            this.tb_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_name.TabIndex = 42;
            this.tb_name.TabStop = false;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name.TextMarginLeft = 5;
            this.tb_name.TextPlaceholder = "Name";
            this.tb_name.UseSystemPasswordChar = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(247, 44);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel7.TabIndex = 44;
            this.bunifuCustomLabel7.Text = "Địa chỉ:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 44);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 17);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "Tên nhân viên:";
            // 
            // date_ngayxuat
            // 
            this.date_ngayxuat.BackColor = System.Drawing.Color.Blue;
            this.date_ngayxuat.BorderRadius = 5;
            this.date_ngayxuat.ForeColor = System.Drawing.Color.White;
            this.date_ngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngayxuat.FormatCustom = "dd/MM/yyyy";
            this.date_ngayxuat.Location = new System.Drawing.Point(542, 59);
            this.date_ngayxuat.Name = "date_ngayxuat";
            this.date_ngayxuat.Size = new System.Drawing.Size(182, 36);
            this.date_ngayxuat.TabIndex = 46;
            this.date_ngayxuat.Value = new System.DateTime(2019, 12, 11, 14, 48, 4, 711);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(551, 41);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 17);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Ngày xuất:";
            // 
            // dgv_ct
            // 
            this.dgv_ct.AllowCustomTheming = false;
            this.dgv_ct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_ct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ct.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ct.ColumnHeadersHeight = 40;
            this.dgv_ct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manl,
            this.tennl,
            this.tendv,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.delete});
            this.dgv_ct.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_ct.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_ct.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ct.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_ct.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_ct.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_ct.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_ct.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_ct.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_ct.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ct.CurrentTheme.Name = null;
            this.dgv_ct.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ct.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_ct.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_ct.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_ct.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_ct.EnableHeadersVisualStyles = false;
            this.dgv_ct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_ct.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_ct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_ct.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_ct.Location = new System.Drawing.Point(12, 178);
            this.dgv_ct.Name = "dgv_ct";
            this.dgv_ct.RowHeadersVisible = false;
            this.dgv_ct.RowTemplate.Height = 40;
            this.dgv_ct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ct.Size = new System.Drawing.Size(831, 269);
            this.dgv_ct.TabIndex = 47;
            this.dgv_ct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_ct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ct_CellClick);
            // 
            // manl
            // 
            this.manl.DataPropertyName = "manl";
            this.manl.HeaderText = "Mã";
            this.manl.Name = "manl";
            this.manl.ReadOnly = true;
            // 
            // tennl
            // 
            this.tennl.DataPropertyName = "tennl";
            this.tennl.HeaderText = "Tên NL";
            this.tennl.Name = "tennl";
            this.tennl.ReadOnly = true;
            // 
            // tendv
            // 
            this.tendv.DataPropertyName = "tendv";
            this.tendv.HeaderText = "Tên đơn vị";
            this.tendv.Name = "tendv";
            this.tendv.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Giá bán";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::CoffeeManagement.Properties.Resources.remove;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_lappx
            // 
            this.btn_lappx.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_lappx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_lappx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lappx.BorderRadius = 0;
            this.btn_lappx.ButtonText = "Lập phiếu xuất";
            this.btn_lappx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lappx.DisabledColor = System.Drawing.Color.Gray;
            this.btn_lappx.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_lappx.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_lappx.Iconimage")));
            this.btn_lappx.Iconimage_right = null;
            this.btn_lappx.Iconimage_right_Selected = null;
            this.btn_lappx.Iconimage_Selected = null;
            this.btn_lappx.IconMarginLeft = 0;
            this.btn_lappx.IconMarginRight = 0;
            this.btn_lappx.IconRightVisible = true;
            this.btn_lappx.IconRightZoom = 0D;
            this.btn_lappx.IconVisible = true;
            this.btn_lappx.IconZoom = 90D;
            this.btn_lappx.IsTab = false;
            this.btn_lappx.Location = new System.Drawing.Point(74, 464);
            this.btn_lappx.Name = "btn_lappx";
            this.btn_lappx.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_lappx.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_lappx.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_lappx.selected = false;
            this.btn_lappx.Size = new System.Drawing.Size(152, 40);
            this.btn_lappx.TabIndex = 48;
            this.btn_lappx.Text = "Lập phiếu xuất";
            this.btn_lappx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lappx.Textcolor = System.Drawing.Color.White;
            this.btn_lappx.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lappx.Click += new System.EventHandler(this.btn_lappx_Click);
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.White;
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.ForeColor = System.Drawing.Color.Red;
            this.tb_price.HintForeColor = System.Drawing.Color.Empty;
            this.tb_price.HintText = "";
            this.tb_price.isPassword = false;
            this.tb_price.LineFocusedColor = System.Drawing.Color.Blue;
            this.tb_price.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tb_price.LineThickness = 4;
            this.tb_price.Location = new System.Drawing.Point(680, 466);
            this.tb_price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(134, 33);
            this.tb_price.TabIndex = 50;
            this.tb_price.Text = "0";
            this.tb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbb
            // 
            this.cbb.BackColor = System.Drawing.Color.White;
            this.cbb.BorderRadius = 5;
            this.cbb.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbb.DisabledColor = System.Drawing.Color.Purple;
            this.cbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbb.FillDropDown = false;
            this.cbb.FillIndicator = false;
            this.cbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb.ForeColor = System.Drawing.Color.Black;
            this.cbb.FormattingEnabled = true;
            this.cbb.Icon = null;
            this.cbb.IndicatorColor = System.Drawing.Color.Black;
            this.cbb.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbb.ItemBackColor = System.Drawing.Color.White;
            this.cbb.ItemBorderColor = System.Drawing.Color.Black;
            this.cbb.ItemForeColor = System.Drawing.Color.Purple;
            this.cbb.ItemHeight = 25;
            this.cbb.ItemHighLightColor = System.Drawing.Color.White;
            this.cbb.Location = new System.Drawing.Point(22, 132);
            this.cbb.MinimumSize = new System.Drawing.Size(48, 0);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(190, 31);
            this.cbb.TabIndex = 54;
            this.cbb.Text = null;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Thêm ";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAdd.DisabledForecolor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAdd.IdleBorderRadius = 25;
            this.btnAdd.IdleBorderThickness = 0;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.Location = new System.Drawing.Point(432, 127);
            this.btnAdd.Name = "btnAdd";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAdd.onHoverState = stateProperties1;
            this.btnAdd.Size = new System.Drawing.Size(95, 36);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tb_soluong
            // 
            this.tb_soluong.AcceptsReturn = false;
            this.tb_soluong.AcceptsTab = false;
            this.tb_soluong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_soluong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_soluong.BackColor = System.Drawing.Color.Transparent;
            this.tb_soluong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_soluong.BackgroundImage")));
            this.tb_soluong.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.tb_soluong.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tb_soluong.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.tb_soluong.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_soluong.BorderRadius = 20;
            this.tb_soluong.BorderThickness = 1;
            this.tb_soluong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_soluong.FillColor = System.Drawing.Color.White;
            this.tb_soluong.HideSelection = true;
            this.tb_soluong.IconLeft = null;
            this.tb_soluong.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_soluong.IconPadding = 10;
            this.tb_soluong.IconRight = null;
            this.tb_soluong.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_soluong.Location = new System.Drawing.Point(240, 128);
            this.tb_soluong.MaximumSize = new System.Drawing.Size(400, 100);
            this.tb_soluong.MaxLength = 32767;
            this.tb_soluong.MinimumSize = new System.Drawing.Size(100, 35);
            this.tb_soluong.Modified = false;
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.PasswordChar = '\0';
            this.tb_soluong.ReadOnly = false;
            this.tb_soluong.SelectedText = "";
            this.tb_soluong.SelectionLength = 0;
            this.tb_soluong.SelectionStart = 0;
            this.tb_soluong.ShortcutsEnabled = true;
            this.tb_soluong.Size = new System.Drawing.Size(151, 35);
            this.tb_soluong.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_soluong.TabIndex = 53;
            this.tb_soluong.TabStop = false;
            this.tb_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_soluong.TextMarginLeft = 5;
            this.tb_soluong.TextPlaceholder = "Số lượng";
            this.tb_soluong.UseSystemPasswordChar = false;
            this.tb_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluong_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(34, 112);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel4.TabIndex = 55;
            this.bunifuCustomLabel4.Text = "Sản phẩm:";
            // 
            // btn_in
            // 
            this.btn_in.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_in.BorderRadius = 0;
            this.btn_in.ButtonText = "In phiếu xuất";
            this.btn_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_in.DisabledColor = System.Drawing.Color.Gray;
            this.btn_in.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_in.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_in.Iconimage")));
            this.btn_in.Iconimage_right = null;
            this.btn_in.Iconimage_right_Selected = null;
            this.btn_in.Iconimage_Selected = null;
            this.btn_in.IconMarginLeft = 0;
            this.btn_in.IconMarginRight = 0;
            this.btn_in.IconRightVisible = true;
            this.btn_in.IconRightZoom = 0D;
            this.btn_in.IconVisible = true;
            this.btn_in.IconZoom = 90D;
            this.btn_in.IsTab = false;
            this.btn_in.Location = new System.Drawing.Point(244, 464);
            this.btn_in.Name = "btn_in";
            this.btn_in.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_in.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_in.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_in.selected = false;
            this.btn_in.Size = new System.Drawing.Size(152, 40);
            this.btn_in.TabIndex = 49;
            this.btn_in.Text = "In phiếu xuất";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Textcolor = System.Drawing.Color.White;
            this.btn_in.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // QLPX_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_lappx);
            this.Controls.Add(this.dgv_ct);
            this.Controls.Add(this.date_ngayxuat);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLPX_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QLPX_ADD";
            this.Load += new System.EventHandler(this.QLPX_ADD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_diachi;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDatepicker date_ngayxuat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_lappx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_price;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuDropdown cbb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_soluong;
        private Bunifu.Framework.UI.BunifuFlatButton btn_in;
    }
}