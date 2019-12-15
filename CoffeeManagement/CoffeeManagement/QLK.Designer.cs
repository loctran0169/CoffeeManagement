namespace CoffeeManagement
{
    partial class QLK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLK));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tb_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgv_ct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "Xuất file";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuButton2.IdleBorderRadius = 35;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(690, 29);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties1;
            this.bunifuButton2.Size = new System.Drawing.Size(121, 35);
            this.bunifuButton2.TabIndex = 32;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
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
            this.tb_name.BorderColorIdle = System.Drawing.Color.MediumTurquoise;
            this.tb_name.BorderRadius = 30;
            this.tb_name.BorderThickness = 1;
            this.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_name.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_name.HideSelection = true;
            this.tb_name.IconLeft = null;
            this.tb_name.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.IconPadding = 10;
            this.tb_name.IconRight = ((System.Drawing.Image)(resources.GetObject("tb_name.IconRight")));
            this.tb_name.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tb_name.Location = new System.Drawing.Point(12, 29);
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
            this.tb_name.ShortcutsEnabled = true;
            this.tb_name.Size = new System.Drawing.Size(354, 35);
            this.tb_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tb_name.TabIndex = 31;
            this.tb_name.TabStop = false;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name.TextMarginLeft = 5;
            this.tb_name.TextPlaceholder = "Nhập mã nguyên liệu";
            this.tb_name.UseSystemPasswordChar = false;
            this.tb_name.OnIconRightClick += new System.EventHandler(this.tb_name_OnIconRightClick);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Thêm mới";
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
            this.bunifuButton1.Location = new System.Drawing.Point(537, 29);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 35;
            stateProperties2.BorderThickness = 0;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(133, 35);
            this.bunifuButton1.TabIndex = 30;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // dgv_ct
            // 
            this.dgv_ct.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_ct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.soluongton,
            this.gianhap,
            this.giaban,
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
            this.dgv_ct.Location = new System.Drawing.Point(12, 96);
            this.dgv_ct.Name = "dgv_ct";
            this.dgv_ct.RowHeadersVisible = false;
            this.dgv_ct.RowTemplate.Height = 40;
            this.dgv_ct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ct.Size = new System.Drawing.Size(831, 408);
            this.dgv_ct.TabIndex = 63;
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
            // soluongton
            // 
            this.soluongton.DataPropertyName = "soluongton";
            this.soluongton.HeaderText = "Số lượng tồn";
            this.soluongton.Name = "soluongton";
            this.soluongton.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            this.gianhap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            this.giaban.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::CoffeeManagement.Properties.Resources.remove;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.dgv_ct);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bunifuButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLK";
            this.Text = "QLK";
            this.Load += new System.EventHandler(this.QLK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tb_name;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}