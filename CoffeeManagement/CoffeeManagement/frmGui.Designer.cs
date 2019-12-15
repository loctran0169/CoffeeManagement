namespace CoffeeManagement
{
    partial class frmGui
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGui));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.drawer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_nhanvien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_donvi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_xuathang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nhaphang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nguyenlieu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_douong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_hoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_banhang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_leftbar = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.tshow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.drawer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
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
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.tshow.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 45);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::CoffeeManagement.Properties.Resources.exit;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1044, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(28, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.drawer.Controls.Add(this.panel2);
            this.drawer.Controls.Add(this.btn_nhanvien);
            this.drawer.Controls.Add(this.btn_donvi);
            this.drawer.Controls.Add(this.btn_xuathang);
            this.drawer.Controls.Add(this.btn_nhaphang);
            this.drawer.Controls.Add(this.btn_nguyenlieu);
            this.drawer.Controls.Add(this.btn_douong);
            this.drawer.Controls.Add(this.btn_hoadon);
            this.drawer.Controls.Add(this.btn_banhang);
            this.drawer.Controls.Add(this.pnl_leftbar);
            this.tshow.SetDecoration(this.drawer, BunifuAnimatorNS.DecorationType.None);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.drawer.Location = new System.Drawing.Point(0, 45);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(198, 516);
            this.drawer.TabIndex = 1;
            this.drawer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_menu);
            this.tshow.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 87);
            this.panel2.TabIndex = 8;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.tshow.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::CoffeeManagement.Properties.Resources.menu;
            this.btn_menu.ImageActive = null;
            this.btn_menu.Location = new System.Drawing.Point(168, 6);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(24, 24);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 0;
            this.btn_menu.TabStop = false;
            this.btn_menu.Zoom = 10;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nhanvien.BorderRadius = 0;
            this.btn_nhanvien.ButtonText = "Nhân viên";
            this.btn_nhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_nhanvien, BunifuAnimatorNS.DecorationType.None);
            this.btn_nhanvien.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nhanvien.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.Iconimage")));
            this.btn_nhanvien.Iconimage_right = null;
            this.btn_nhanvien.Iconimage_right_Selected = null;
            this.btn_nhanvien.Iconimage_Selected = null;
            this.btn_nhanvien.IconMarginLeft = 0;
            this.btn_nhanvien.IconMarginRight = 0;
            this.btn_nhanvien.IconRightVisible = true;
            this.btn_nhanvien.IconRightZoom = 0D;
            this.btn_nhanvien.IconVisible = true;
            this.btn_nhanvien.IconZoom = 90D;
            this.btn_nhanvien.IsTab = false;
            this.btn_nhanvien.Location = new System.Drawing.Point(8, 359);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhanvien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhanvien.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_nhanvien.selected = false;
            this.btn_nhanvien.Size = new System.Drawing.Size(189, 35);
            this.btn_nhanvien.TabIndex = 6;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Textcolor = System.Drawing.Color.White;
            this.btn_nhanvien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_donvi
            // 
            this.btn_donvi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_donvi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_donvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_donvi.BorderRadius = 0;
            this.btn_donvi.ButtonText = "Đơn vị";
            this.btn_donvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_donvi, BunifuAnimatorNS.DecorationType.None);
            this.btn_donvi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_donvi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_donvi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_donvi.Iconimage")));
            this.btn_donvi.Iconimage_right = null;
            this.btn_donvi.Iconimage_right_Selected = null;
            this.btn_donvi.Iconimage_Selected = null;
            this.btn_donvi.IconMarginLeft = 0;
            this.btn_donvi.IconMarginRight = 0;
            this.btn_donvi.IconRightVisible = true;
            this.btn_donvi.IconRightZoom = 0D;
            this.btn_donvi.IconVisible = true;
            this.btn_donvi.IconZoom = 90D;
            this.btn_donvi.IsTab = false;
            this.btn_donvi.Location = new System.Drawing.Point(8, 321);
            this.btn_donvi.Name = "btn_donvi";
            this.btn_donvi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_donvi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_donvi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_donvi.selected = false;
            this.btn_donvi.Size = new System.Drawing.Size(189, 35);
            this.btn_donvi.TabIndex = 2;
            this.btn_donvi.Text = "Đơn vị";
            this.btn_donvi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donvi.Textcolor = System.Drawing.Color.White;
            this.btn_donvi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donvi.Click += new System.EventHandler(this.btn_donvi_Click);
            // 
            // btn_xuathang
            // 
            this.btn_xuathang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_xuathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_xuathang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xuathang.BorderRadius = 0;
            this.btn_xuathang.ButtonText = "Xuất hàng";
            this.btn_xuathang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_xuathang, BunifuAnimatorNS.DecorationType.None);
            this.btn_xuathang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_xuathang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_xuathang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_xuathang.Iconimage")));
            this.btn_xuathang.Iconimage_right = null;
            this.btn_xuathang.Iconimage_right_Selected = null;
            this.btn_xuathang.Iconimage_Selected = null;
            this.btn_xuathang.IconMarginLeft = 0;
            this.btn_xuathang.IconMarginRight = 0;
            this.btn_xuathang.IconRightVisible = true;
            this.btn_xuathang.IconRightZoom = 0D;
            this.btn_xuathang.IconVisible = true;
            this.btn_xuathang.IconZoom = 90D;
            this.btn_xuathang.IsTab = false;
            this.btn_xuathang.Location = new System.Drawing.Point(8, 283);
            this.btn_xuathang.Name = "btn_xuathang";
            this.btn_xuathang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_xuathang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_xuathang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_xuathang.selected = false;
            this.btn_xuathang.Size = new System.Drawing.Size(189, 35);
            this.btn_xuathang.TabIndex = 2;
            this.btn_xuathang.Text = "Xuất hàng";
            this.btn_xuathang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuathang.Textcolor = System.Drawing.Color.White;
            this.btn_xuathang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuathang.Click += new System.EventHandler(this.btn_xuathang_Click);
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhaphang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhaphang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nhaphang.BorderRadius = 0;
            this.btn_nhaphang.ButtonText = "Nhập hàng";
            this.btn_nhaphang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_nhaphang, BunifuAnimatorNS.DecorationType.None);
            this.btn_nhaphang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nhaphang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nhaphang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nhaphang.Iconimage")));
            this.btn_nhaphang.Iconimage_right = null;
            this.btn_nhaphang.Iconimage_right_Selected = null;
            this.btn_nhaphang.Iconimage_Selected = null;
            this.btn_nhaphang.IconMarginLeft = 0;
            this.btn_nhaphang.IconMarginRight = 0;
            this.btn_nhaphang.IconRightVisible = true;
            this.btn_nhaphang.IconRightZoom = 0D;
            this.btn_nhaphang.IconVisible = true;
            this.btn_nhaphang.IconZoom = 90D;
            this.btn_nhaphang.IsTab = false;
            this.btn_nhaphang.Location = new System.Drawing.Point(8, 245);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhaphang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nhaphang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_nhaphang.selected = false;
            this.btn_nhaphang.Size = new System.Drawing.Size(189, 35);
            this.btn_nhaphang.TabIndex = 5;
            this.btn_nhaphang.Text = "Nhập hàng";
            this.btn_nhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaphang.Textcolor = System.Drawing.Color.White;
            this.btn_nhaphang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // btn_nguyenlieu
            // 
            this.btn_nguyenlieu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nguyenlieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nguyenlieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nguyenlieu.BorderRadius = 0;
            this.btn_nguyenlieu.ButtonText = "Nguyên liệu";
            this.btn_nguyenlieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_nguyenlieu, BunifuAnimatorNS.DecorationType.None);
            this.btn_nguyenlieu.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nguyenlieu.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nguyenlieu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nguyenlieu.Iconimage")));
            this.btn_nguyenlieu.Iconimage_right = null;
            this.btn_nguyenlieu.Iconimage_right_Selected = null;
            this.btn_nguyenlieu.Iconimage_Selected = null;
            this.btn_nguyenlieu.IconMarginLeft = 0;
            this.btn_nguyenlieu.IconMarginRight = 0;
            this.btn_nguyenlieu.IconRightVisible = true;
            this.btn_nguyenlieu.IconRightZoom = 0D;
            this.btn_nguyenlieu.IconVisible = true;
            this.btn_nguyenlieu.IconZoom = 90D;
            this.btn_nguyenlieu.IsTab = false;
            this.btn_nguyenlieu.Location = new System.Drawing.Point(8, 207);
            this.btn_nguyenlieu.Name = "btn_nguyenlieu";
            this.btn_nguyenlieu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nguyenlieu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_nguyenlieu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_nguyenlieu.selected = false;
            this.btn_nguyenlieu.Size = new System.Drawing.Size(189, 35);
            this.btn_nguyenlieu.TabIndex = 4;
            this.btn_nguyenlieu.Text = "Nguyên liệu";
            this.btn_nguyenlieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nguyenlieu.Textcolor = System.Drawing.Color.White;
            this.btn_nguyenlieu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nguyenlieu.Click += new System.EventHandler(this.btn_nguyenlieu_Click);
            // 
            // btn_douong
            // 
            this.btn_douong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_douong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_douong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_douong.BorderRadius = 0;
            this.btn_douong.ButtonText = "Đồ uống";
            this.btn_douong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_douong, BunifuAnimatorNS.DecorationType.None);
            this.btn_douong.DisabledColor = System.Drawing.Color.Gray;
            this.btn_douong.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_douong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_douong.Iconimage")));
            this.btn_douong.Iconimage_right = null;
            this.btn_douong.Iconimage_right_Selected = null;
            this.btn_douong.Iconimage_Selected = null;
            this.btn_douong.IconMarginLeft = 0;
            this.btn_douong.IconMarginRight = 0;
            this.btn_douong.IconRightVisible = true;
            this.btn_douong.IconRightZoom = 0D;
            this.btn_douong.IconVisible = true;
            this.btn_douong.IconZoom = 90D;
            this.btn_douong.IsTab = false;
            this.btn_douong.Location = new System.Drawing.Point(8, 169);
            this.btn_douong.Name = "btn_douong";
            this.btn_douong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_douong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_douong.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_douong.selected = false;
            this.btn_douong.Size = new System.Drawing.Size(189, 35);
            this.btn_douong.TabIndex = 3;
            this.btn_douong.Text = "Đồ uống";
            this.btn_douong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_douong.Textcolor = System.Drawing.Color.White;
            this.btn_douong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_douong.Click += new System.EventHandler(this.btn_douong_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_hoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hoadon.BorderRadius = 0;
            this.btn_hoadon.ButtonText = "Hóa đơn";
            this.btn_hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_hoadon, BunifuAnimatorNS.DecorationType.None);
            this.btn_hoadon.DisabledColor = System.Drawing.Color.Gray;
            this.btn_hoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_hoadon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_hoadon.Iconimage")));
            this.btn_hoadon.Iconimage_right = null;
            this.btn_hoadon.Iconimage_right_Selected = null;
            this.btn_hoadon.Iconimage_Selected = null;
            this.btn_hoadon.IconMarginLeft = 0;
            this.btn_hoadon.IconMarginRight = 0;
            this.btn_hoadon.IconRightVisible = true;
            this.btn_hoadon.IconRightZoom = 0D;
            this.btn_hoadon.IconVisible = true;
            this.btn_hoadon.IconZoom = 90D;
            this.btn_hoadon.IsTab = false;
            this.btn_hoadon.Location = new System.Drawing.Point(8, 131);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_hoadon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_hoadon.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_hoadon.selected = false;
            this.btn_hoadon.Size = new System.Drawing.Size(189, 35);
            this.btn_hoadon.TabIndex = 2;
            this.btn_hoadon.Text = "Hóa đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Textcolor = System.Drawing.Color.White;
            this.btn_hoadon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_banhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_banhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_banhang.BorderRadius = 0;
            this.btn_banhang.ButtonText = "Bán hàng";
            this.btn_banhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btn_banhang, BunifuAnimatorNS.DecorationType.None);
            this.btn_banhang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_banhang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_banhang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_banhang.Iconimage")));
            this.btn_banhang.Iconimage_right = null;
            this.btn_banhang.Iconimage_right_Selected = null;
            this.btn_banhang.Iconimage_Selected = null;
            this.btn_banhang.IconMarginLeft = 0;
            this.btn_banhang.IconMarginRight = 0;
            this.btn_banhang.IconRightVisible = true;
            this.btn_banhang.IconRightZoom = 0D;
            this.btn_banhang.IconVisible = true;
            this.btn_banhang.IconZoom = 90D;
            this.btn_banhang.IsTab = false;
            this.btn_banhang.Location = new System.Drawing.Point(8, 95);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_banhang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.btn_banhang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_banhang.selected = true;
            this.btn_banhang.Size = new System.Drawing.Size(190, 35);
            this.btn_banhang.TabIndex = 1;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Textcolor = System.Drawing.Color.White;
            this.btn_banhang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // pnl_leftbar
            // 
            this.pnl_leftbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.tshow.SetDecoration(this.pnl_leftbar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_leftbar.Location = new System.Drawing.Point(0, 93);
            this.pnl_leftbar.Name = "pnl_leftbar";
            this.pnl_leftbar.Size = new System.Drawing.Size(5, 40);
            this.pnl_leftbar.TabIndex = 7;
            // 
            // content
            // 
            this.tshow.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(198, 45);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(886, 516);
            this.content.TabIndex = 5;
            // 
            // tshow
            // 
            this.tshow.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.tshow.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tshow.DefaultAnimation = animation1;
            this.tshow.TimeStep = 0.01F;
            // 
            // frmGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.content);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.panel1);
            this.tshow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGui_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.drawer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_menu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_donvi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_xuathang;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nhaphang;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nguyenlieu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_douong;
        private Bunifu.Framework.UI.BunifuFlatButton btn_hoadon;
        private Bunifu.Framework.UI.BunifuFlatButton btn_banhang;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nhanvien;
        private System.Windows.Forms.Panel pnl_leftbar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition tshow;
    }
}