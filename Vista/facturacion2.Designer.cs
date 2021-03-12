namespace Vista
{
    partial class facturacion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturacion2));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cargar_inventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.anular_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ingresar_clien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ingresar_fac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelmenu2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu1 = new System.Windows.Forms.Panel();
            this.animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelmenu2)).BeginInit();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel_menu);
            this.animacion2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 480);
            this.panel2.TabIndex = 1;
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_menu.BackgroundImage")));
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.Controls.Add(this.label2);
            this.panel_menu.Controls.Add(this.cargar_inventario);
            this.panel_menu.Controls.Add(this.anular_fac);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.ingresar_clien);
            this.panel_menu.Controls.Add(this.ingresar_fac);
            this.animacion2.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_menu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_menu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_menu.GradientTopLeft = System.Drawing.Color.Blue;
            this.panel_menu.GradientTopRight = System.Drawing.Color.White;
            this.panel_menu.Location = new System.Drawing.Point(4, 6);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Quality = 10;
            this.panel_menu.Size = new System.Drawing.Size(134, 471);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Proyecto";
            // 
            // cargar_inventario
            // 
            this.cargar_inventario.Activecolor = System.Drawing.Color.Transparent;
            this.cargar_inventario.BackColor = System.Drawing.Color.Transparent;
            this.cargar_inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar_inventario.BorderRadius = 0;
            this.cargar_inventario.ButtonText = "Cargar inventario";
            this.cargar_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.cargar_inventario, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.cargar_inventario, BunifuAnimatorNS.DecorationType.None);
            this.cargar_inventario.DisabledColor = System.Drawing.Color.Gray;
            this.cargar_inventario.Iconcolor = System.Drawing.Color.Transparent;
            this.cargar_inventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("cargar_inventario.Iconimage")));
            this.cargar_inventario.Iconimage_right = null;
            this.cargar_inventario.Iconimage_right_Selected = null;
            this.cargar_inventario.Iconimage_Selected = null;
            this.cargar_inventario.IconMarginLeft = 0;
            this.cargar_inventario.IconMarginRight = 0;
            this.cargar_inventario.IconRightVisible = true;
            this.cargar_inventario.IconRightZoom = 0D;
            this.cargar_inventario.IconVisible = true;
            this.cargar_inventario.IconZoom = 90D;
            this.cargar_inventario.IsTab = false;
            this.cargar_inventario.Location = new System.Drawing.Point(9, 351);
            this.cargar_inventario.Name = "cargar_inventario";
            this.cargar_inventario.Normalcolor = System.Drawing.Color.Transparent;
            this.cargar_inventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.cargar_inventario.OnHoverTextColor = System.Drawing.Color.White;
            this.cargar_inventario.selected = false;
            this.cargar_inventario.Size = new System.Drawing.Size(122, 45);
            this.cargar_inventario.TabIndex = 10;
            this.cargar_inventario.Text = "Cargar inventario";
            this.cargar_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargar_inventario.Textcolor = System.Drawing.Color.Black;
            this.cargar_inventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar_inventario.Click += new System.EventHandler(this.cargar_inventario_Click);
            // 
            // anular_fac
            // 
            this.anular_fac.Activecolor = System.Drawing.Color.Transparent;
            this.anular_fac.BackColor = System.Drawing.Color.Transparent;
            this.anular_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anular_fac.BorderRadius = 0;
            this.anular_fac.ButtonText = "Anular factura";
            this.anular_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.anular_fac, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.anular_fac, BunifuAnimatorNS.DecorationType.None);
            this.anular_fac.DisabledColor = System.Drawing.Color.Gray;
            this.anular_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.anular_fac.Iconimage = ((System.Drawing.Image)(resources.GetObject("anular_fac.Iconimage")));
            this.anular_fac.Iconimage_right = null;
            this.anular_fac.Iconimage_right_Selected = null;
            this.anular_fac.Iconimage_Selected = null;
            this.anular_fac.IconMarginLeft = 0;
            this.anular_fac.IconMarginRight = 0;
            this.anular_fac.IconRightVisible = true;
            this.anular_fac.IconRightZoom = 0D;
            this.anular_fac.IconVisible = true;
            this.anular_fac.IconZoom = 90D;
            this.anular_fac.IsTab = false;
            this.anular_fac.Location = new System.Drawing.Point(8, 273);
            this.anular_fac.Name = "anular_fac";
            this.anular_fac.Normalcolor = System.Drawing.Color.Transparent;
            this.anular_fac.OnHovercolor = System.Drawing.Color.Transparent;
            this.anular_fac.OnHoverTextColor = System.Drawing.Color.White;
            this.anular_fac.selected = false;
            this.anular_fac.Size = new System.Drawing.Size(122, 45);
            this.anular_fac.TabIndex = 8;
            this.anular_fac.Text = "Anular factura";
            this.anular_fac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anular_fac.Textcolor = System.Drawing.Color.Black;
            this.anular_fac.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anular_fac.Click += new System.EventHandler(this.anular_fac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ingresar_clien
            // 
            this.ingresar_clien.Activecolor = System.Drawing.Color.Transparent;
            this.ingresar_clien.BackColor = System.Drawing.Color.Transparent;
            this.ingresar_clien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingresar_clien.BorderRadius = 0;
            this.ingresar_clien.ButtonText = "Ingresar cliente";
            this.ingresar_clien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.ingresar_clien, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.ingresar_clien, BunifuAnimatorNS.DecorationType.None);
            this.ingresar_clien.DisabledColor = System.Drawing.Color.Gray;
            this.ingresar_clien.Iconcolor = System.Drawing.Color.Transparent;
            this.ingresar_clien.Iconimage = ((System.Drawing.Image)(resources.GetObject("ingresar_clien.Iconimage")));
            this.ingresar_clien.Iconimage_right = null;
            this.ingresar_clien.Iconimage_right_Selected = null;
            this.ingresar_clien.Iconimage_Selected = null;
            this.ingresar_clien.IconMarginLeft = 0;
            this.ingresar_clien.IconMarginRight = 0;
            this.ingresar_clien.IconRightVisible = true;
            this.ingresar_clien.IconRightZoom = 0D;
            this.ingresar_clien.IconVisible = true;
            this.ingresar_clien.IconZoom = 90D;
            this.ingresar_clien.IsTab = false;
            this.ingresar_clien.Location = new System.Drawing.Point(9, 185);
            this.ingresar_clien.Name = "ingresar_clien";
            this.ingresar_clien.Normalcolor = System.Drawing.Color.Transparent;
            this.ingresar_clien.OnHovercolor = System.Drawing.Color.Transparent;
            this.ingresar_clien.OnHoverTextColor = System.Drawing.Color.White;
            this.ingresar_clien.selected = false;
            this.ingresar_clien.Size = new System.Drawing.Size(122, 45);
            this.ingresar_clien.TabIndex = 7;
            this.ingresar_clien.Text = "Ingresar cliente";
            this.ingresar_clien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ingresar_clien.Textcolor = System.Drawing.Color.Black;
            this.ingresar_clien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar_clien.Click += new System.EventHandler(this.ingresar_clien_Click);
            // 
            // ingresar_fac
            // 
            this.ingresar_fac.Activecolor = System.Drawing.Color.Transparent;
            this.ingresar_fac.BackColor = System.Drawing.Color.Transparent;
            this.ingresar_fac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingresar_fac.BorderRadius = 0;
            this.ingresar_fac.ButtonText = "Mostrar factura";
            this.ingresar_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.ingresar_fac, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.ingresar_fac, BunifuAnimatorNS.DecorationType.None);
            this.ingresar_fac.DisabledColor = System.Drawing.Color.Gray;
            this.ingresar_fac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ingresar_fac.Iconcolor = System.Drawing.Color.Transparent;
            this.ingresar_fac.Iconimage = ((System.Drawing.Image)(resources.GetObject("ingresar_fac.Iconimage")));
            this.ingresar_fac.Iconimage_right = null;
            this.ingresar_fac.Iconimage_right_Selected = null;
            this.ingresar_fac.Iconimage_Selected = null;
            this.ingresar_fac.IconMarginLeft = 0;
            this.ingresar_fac.IconMarginRight = 0;
            this.ingresar_fac.IconRightVisible = true;
            this.ingresar_fac.IconRightZoom = 0D;
            this.ingresar_fac.IconVisible = true;
            this.ingresar_fac.IconZoom = 90D;
            this.ingresar_fac.IsTab = false;
            this.ingresar_fac.Location = new System.Drawing.Point(8, 94);
            this.ingresar_fac.Name = "ingresar_fac";
            this.ingresar_fac.Normalcolor = System.Drawing.Color.Transparent;
            this.ingresar_fac.OnHovercolor = System.Drawing.Color.Transparent;
            this.ingresar_fac.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.ingresar_fac.selected = false;
            this.ingresar_fac.Size = new System.Drawing.Size(122, 58);
            this.ingresar_fac.TabIndex = 5;
            this.ingresar_fac.Text = "Mostrar factura";
            this.ingresar_fac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ingresar_fac.Textcolor = System.Drawing.Color.Black;
            this.ingresar_fac.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar_fac.Click += new System.EventHandler(this.ingresar_fac_Click);
            // 
            // curva
            // 
            this.curva.ElipseRadius = 5;
            this.curva.TargetControl = this.panel_menu;
            // 
            // animacion1
            // 
            this.animacion1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animacion1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animacion1.DefaultAnimation = animation1;
            // 
            // panelmenu2
            // 
            this.animacion1.SetDecoration(this.panelmenu2, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.panelmenu2, BunifuAnimatorNS.DecorationType.None);
            this.panelmenu2.Image = ((System.Drawing.Image)(resources.GetObject("panelmenu2.Image")));
            this.panelmenu2.Location = new System.Drawing.Point(33, 13);
            this.panelmenu2.Name = "panelmenu2";
            this.panelmenu2.Size = new System.Drawing.Size(23, 20);
            this.panelmenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelmenu2.TabIndex = 1;
            this.panelmenu2.TabStop = false;
            this.panelmenu2.Click += new System.EventHandler(this.panelmenu2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animacion1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facturación";
            // 
            // atras
            // 
            this.atras.Activecolor = System.Drawing.Color.White;
            this.atras.BackColor = System.Drawing.Color.Transparent;
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.atras.BorderRadius = 1;
            this.atras.ButtonText = "";
            this.atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.atras, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.atras, BunifuAnimatorNS.DecorationType.None);
            this.atras.DisabledColor = System.Drawing.Color.Gray;
            this.atras.Iconcolor = System.Drawing.Color.Transparent;
            this.atras.Iconimage = ((System.Drawing.Image)(resources.GetObject("atras.Iconimage")));
            this.atras.Iconimage_right = null;
            this.atras.Iconimage_right_Selected = null;
            this.atras.Iconimage_Selected = null;
            this.atras.IconMarginLeft = 0;
            this.atras.IconMarginRight = 0;
            this.atras.IconRightVisible = true;
            this.atras.IconRightZoom = 0D;
            this.atras.IconVisible = true;
            this.atras.IconZoom = 75D;
            this.atras.IsTab = false;
            this.atras.Location = new System.Drawing.Point(799, 5);
            this.atras.Name = "atras";
            this.atras.Normalcolor = System.Drawing.Color.Transparent;
            this.atras.OnHovercolor = System.Drawing.Color.Transparent;
            this.atras.OnHoverTextColor = System.Drawing.Color.White;
            this.atras.selected = false;
            this.atras.Size = new System.Drawing.Size(37, 37);
            this.atras.TabIndex = 5;
            this.atras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atras.Textcolor = System.Drawing.Color.White;
            this.atras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menu1.Controls.Add(this.atras);
            this.menu1.Controls.Add(this.label1);
            this.menu1.Controls.Add(this.panelmenu2);
            this.animacion2.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(858, 45);
            this.menu1.TabIndex = 1;
            this.menu1.Paint += new System.Windows.Forms.PaintEventHandler(this.menu1_Paint);
            // 
            // animacion2
            // 
            this.animacion2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animacion2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animacion2.DefaultAnimation = animation2;
            // 
            // facturacion2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(858, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu1);
            this.animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "facturacion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.panel2.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelmenu2)).EndInit();
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton ingresar_fac;
        private Bunifu.Framework.UI.BunifuFlatButton anular_fac;
        private Bunifu.Framework.UI.BunifuFlatButton ingresar_clien;
        private Bunifu.Framework.UI.BunifuFlatButton cargar_inventario;
        private Bunifu.Framework.UI.BunifuElipse curva;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition animacion2;
        private BunifuAnimatorNS.BunifuTransition animacion1;
        private System.Windows.Forms.PictureBox panelmenu2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton atras;
        private System.Windows.Forms.Panel menu1;
    }
}