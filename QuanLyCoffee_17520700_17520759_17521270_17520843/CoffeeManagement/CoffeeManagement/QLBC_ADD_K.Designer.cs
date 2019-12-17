namespace CoffeeManagement
{
    partial class QLBC_ADD_K
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBC_ADD_K));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.date_month = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgv_ct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton1.Image = global::CoffeeManagement.Properties.Resources.left_arrow_1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(8, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 54;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(36, 9);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(129, 21);
            this.bunifuCustomLabel10.TabIndex = 55;
            this.bunifuCustomLabel10.Text = "Lập báo cáo kho";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.date_month);
            this.panel2.Controls.Add(this.dgv_ct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 429);
            this.panel2.TabIndex = 3;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "In báo cáo";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(633, 56);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(109, 35);
            this.bunifuFlatButton2.TabIndex = 50;
            this.bunifuFlatButton2.Text = "In báo cáo";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Xem";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(507, 56);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(109, 35);
            this.bunifuFlatButton1.TabIndex = 49;
            this.bunifuFlatButton1.Text = "Xem";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // date_month
            // 
            this.date_month.BackColor = System.Drawing.Color.DarkTurquoise;
            this.date_month.BorderRadius = 10;
            this.date_month.ForeColor = System.Drawing.Color.Black;
            this.date_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_month.FormatCustom = "MM/yyy";
            this.date_month.Location = new System.Drawing.Point(30, 55);
            this.date_month.Name = "date_month";
            this.date_month.Size = new System.Drawing.Size(234, 36);
            this.date_month.TabIndex = 48;
            this.date_month.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
            this.date_month.onValueChanged += new System.EventHandler(this.date_month_onValueChanged);
            // 
            // dgv_ct
            // 
            this.dgv_ct.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_ct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ct.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
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
            this.giaban});
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
            this.dgv_ct.EnableHeadersVisualStyles = false;
            this.dgv_ct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_ct.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_ct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_ct.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_ct.Location = new System.Drawing.Point(8, 108);
            this.dgv_ct.Name = "dgv_ct";
            this.dgv_ct.RowHeadersVisible = false;
            this.dgv_ct.RowTemplate.Height = 40;
            this.dgv_ct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ct.Size = new System.Drawing.Size(781, 309);
            this.dgv_ct.TabIndex = 45;
            this.dgv_ct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // manl
            // 
            this.manl.DataPropertyName = "manl";
            this.manl.HeaderText = "Mã NL";
            this.manl.Name = "manl";
            // 
            // tennl
            // 
            this.tennl.DataPropertyName = "tennl";
            this.tennl.HeaderText = "Tên NL";
            this.tennl.Name = "tennl";
            // 
            // tendv
            // 
            this.tendv.DataPropertyName = "tendv";
            this.tendv.HeaderText = "Tên DV";
            this.tendv.Name = "tendv";
            // 
            // soluongton
            // 
            this.soluongton.DataPropertyName = "soluongton";
            this.soluongton.HeaderText = "SL tồn";
            this.soluongton.Name = "soluongton";
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            // 
            // QLBC_ADD_K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLBC_ADD_K";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QLBC_ADD_K";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_ct;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDatepicker date_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
    }
}