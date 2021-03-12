namespace Vista
{
    partial class MenuInventario
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInventario));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_Tienda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_IngresarProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Hacerpedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarArticulo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu1 = new System.Windows.Forms.Panel();
            this.atras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelmenu2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // animacion1
            // 
            this.animacion1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animacion1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animacion1.DefaultAnimation = animation3;
            // 
            // btn_Tienda
            // 
            this.btn_Tienda.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Tienda.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tienda.BorderRadius = 0;
            this.btn_Tienda.ButtonText = "Tienda";
            this.btn_Tienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_Tienda, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_Tienda, BunifuAnimatorNS.DecorationType.None);
            this.btn_Tienda.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Tienda.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Tienda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Tienda.Iconimage")));
            this.btn_Tienda.Iconimage_right = null;
            this.btn_Tienda.Iconimage_right_Selected = null;
            this.btn_Tienda.Iconimage_Selected = null;
            this.btn_Tienda.IconMarginLeft = 0;
            this.btn_Tienda.IconMarginRight = 0;
            this.btn_Tienda.IconRightVisible = true;
            this.btn_Tienda.IconRightZoom = 0D;
            this.btn_Tienda.IconVisible = true;
            this.btn_Tienda.IconZoom = 90D;
            this.btn_Tienda.IsTab = false;
            this.btn_Tienda.Location = new System.Drawing.Point(9, 401);
            this.btn_Tienda.Name = "btn_Tienda";
            this.btn_Tienda.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Tienda.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Tienda.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Tienda.selected = false;
            this.btn_Tienda.Size = new System.Drawing.Size(122, 45);
            this.btn_Tienda.TabIndex = 13;
            this.btn_Tienda.Text = "Tienda";
            this.btn_Tienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tienda.Textcolor = System.Drawing.Color.Black;
            this.btn_Tienda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tienda.Click += new System.EventHandler(this.btn_Tienda_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Inventario.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inventario.BorderRadius = 0;
            this.btn_Inventario.ButtonText = "Descarga Inventario";
            this.btn_Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_Inventario, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_Inventario, BunifuAnimatorNS.DecorationType.None);
            this.btn_Inventario.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Inventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Inventario.Iconimage")));
            this.btn_Inventario.Iconimage_right = null;
            this.btn_Inventario.Iconimage_right_Selected = null;
            this.btn_Inventario.Iconimage_Selected = null;
            this.btn_Inventario.IconMarginLeft = 0;
            this.btn_Inventario.IconMarginRight = 0;
            this.btn_Inventario.IconRightVisible = true;
            this.btn_Inventario.IconRightZoom = 0D;
            this.btn_Inventario.IconVisible = true;
            this.btn_Inventario.IconZoom = 90D;
            this.btn_Inventario.IsTab = false;
            this.btn_Inventario.Location = new System.Drawing.Point(9, 327);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Inventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Inventario.selected = false;
            this.btn_Inventario.Size = new System.Drawing.Size(122, 45);
            this.btn_Inventario.TabIndex = 12;
            this.btn_Inventario.Text = "Descarga Inventario";
            this.btn_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventario.Textcolor = System.Drawing.Color.Black;
            this.btn_Inventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Proyecto";
            // 
            // btn_Bodega
            // 
            this.btn_Bodega.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Bodega.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Bodega.BorderRadius = 0;
            this.btn_Bodega.ButtonText = "Bodega";
            this.btn_Bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_Bodega, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_Bodega, BunifuAnimatorNS.DecorationType.None);
            this.btn_Bodega.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Bodega.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Bodega.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Bodega.Iconimage")));
            this.btn_Bodega.Iconimage_right = null;
            this.btn_Bodega.Iconimage_right_Selected = null;
            this.btn_Bodega.Iconimage_Selected = null;
            this.btn_Bodega.IconMarginLeft = 0;
            this.btn_Bodega.IconMarginRight = 0;
            this.btn_Bodega.IconRightVisible = true;
            this.btn_Bodega.IconRightZoom = 0D;
            this.btn_Bodega.IconVisible = true;
            this.btn_Bodega.IconZoom = 90D;
            this.btn_Bodega.IsTab = false;
            this.btn_Bodega.Location = new System.Drawing.Point(9, 253);
            this.btn_Bodega.Name = "btn_Bodega";
            this.btn_Bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Bodega.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Bodega.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Bodega.selected = false;
            this.btn_Bodega.Size = new System.Drawing.Size(122, 45);
            this.btn_Bodega.TabIndex = 10;
            this.btn_Bodega.Text = "Bodega";
            this.btn_Bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bodega.Textcolor = System.Drawing.Color.Black;
            this.btn_Bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bodega.Click += new System.EventHandler(this.btn_Bodega_Click);
            // 
            // btn_IngresarProveedor
            // 
            this.btn_IngresarProveedor.Activecolor = System.Drawing.Color.Transparent;
            this.btn_IngresarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_IngresarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IngresarProveedor.BorderRadius = 0;
            this.btn_IngresarProveedor.ButtonText = "Ingresar proveedor";
            this.btn_IngresarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_IngresarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_IngresarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.btn_IngresarProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_IngresarProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_IngresarProveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_IngresarProveedor.Iconimage")));
            this.btn_IngresarProveedor.Iconimage_right = null;
            this.btn_IngresarProveedor.Iconimage_right_Selected = null;
            this.btn_IngresarProveedor.Iconimage_Selected = null;
            this.btn_IngresarProveedor.IconMarginLeft = 0;
            this.btn_IngresarProveedor.IconMarginRight = 0;
            this.btn_IngresarProveedor.IconRightVisible = true;
            this.btn_IngresarProveedor.IconRightZoom = 0D;
            this.btn_IngresarProveedor.IconVisible = true;
            this.btn_IngresarProveedor.IconZoom = 90D;
            this.btn_IngresarProveedor.IsTab = false;
            this.btn_IngresarProveedor.Location = new System.Drawing.Point(9, 183);
            this.btn_IngresarProveedor.Name = "btn_IngresarProveedor";
            this.btn_IngresarProveedor.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_IngresarProveedor.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_IngresarProveedor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_IngresarProveedor.selected = false;
            this.btn_IngresarProveedor.Size = new System.Drawing.Size(122, 45);
            this.btn_IngresarProveedor.TabIndex = 8;
            this.btn_IngresarProveedor.Text = "Ingresar proveedor";
            this.btn_IngresarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IngresarProveedor.Textcolor = System.Drawing.Color.Black;
            this.btn_IngresarProveedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresarProveedor.Click += new System.EventHandler(this.btn_IngresarProveedor_Click);
            // 
            // btn_Hacerpedido
            // 
            this.btn_Hacerpedido.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Hacerpedido.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hacerpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hacerpedido.BorderRadius = 0;
            this.btn_Hacerpedido.ButtonText = "Hacer pedido";
            this.btn_Hacerpedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_Hacerpedido, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_Hacerpedido, BunifuAnimatorNS.DecorationType.None);
            this.btn_Hacerpedido.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Hacerpedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Hacerpedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Hacerpedido.Iconimage")));
            this.btn_Hacerpedido.Iconimage_right = null;
            this.btn_Hacerpedido.Iconimage_right_Selected = null;
            this.btn_Hacerpedido.Iconimage_Selected = null;
            this.btn_Hacerpedido.IconMarginLeft = 0;
            this.btn_Hacerpedido.IconMarginRight = 0;
            this.btn_Hacerpedido.IconRightVisible = true;
            this.btn_Hacerpedido.IconRightZoom = 0D;
            this.btn_Hacerpedido.IconVisible = true;
            this.btn_Hacerpedido.IconZoom = 90D;
            this.btn_Hacerpedido.IsTab = false;
            this.btn_Hacerpedido.Location = new System.Drawing.Point(9, 122);
            this.btn_Hacerpedido.Name = "btn_Hacerpedido";
            this.btn_Hacerpedido.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Hacerpedido.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Hacerpedido.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Hacerpedido.selected = false;
            this.btn_Hacerpedido.Size = new System.Drawing.Size(122, 45);
            this.btn_Hacerpedido.TabIndex = 7;
            this.btn_Hacerpedido.Text = "Hacer pedido";
            this.btn_Hacerpedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hacerpedido.Textcolor = System.Drawing.Color.Black;
            this.btn_Hacerpedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hacerpedido.Click += new System.EventHandler(this.btn_Hacerpedido_Click);
            // 
            // btn_AgregarArticulo
            // 
            this.btn_AgregarArticulo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarArticulo.BorderRadius = 0;
            this.btn_AgregarArticulo.ButtonText = "Agregar artículo";
            this.btn_AgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion1.SetDecoration(this.btn_AgregarArticulo, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.btn_AgregarArticulo, BunifuAnimatorNS.DecorationType.None);
            this.btn_AgregarArticulo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AgregarArticulo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarArticulo.Iconimage")));
            this.btn_AgregarArticulo.Iconimage_right = null;
            this.btn_AgregarArticulo.Iconimage_right_Selected = null;
            this.btn_AgregarArticulo.Iconimage_Selected = null;
            this.btn_AgregarArticulo.IconMarginLeft = 0;
            this.btn_AgregarArticulo.IconMarginRight = 0;
            this.btn_AgregarArticulo.IconRightVisible = true;
            this.btn_AgregarArticulo.IconRightZoom = 0D;
            this.btn_AgregarArticulo.IconVisible = true;
            this.btn_AgregarArticulo.IconZoom = 90D;
            this.btn_AgregarArticulo.IsTab = false;
            this.btn_AgregarArticulo.Location = new System.Drawing.Point(3, 58);
            this.btn_AgregarArticulo.Name = "btn_AgregarArticulo";
            this.btn_AgregarArticulo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulo.selected = false;
            this.btn_AgregarArticulo.Size = new System.Drawing.Size(122, 58);
            this.btn_AgregarArticulo.TabIndex = 5;
            this.btn_AgregarArticulo.Text = "Agregar artículo";
            this.btn_AgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarArticulo.Textcolor = System.Drawing.Color.Black;
            this.btn_AgregarArticulo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArticulo.Click += new System.EventHandler(this.btn_AgregarArticulo_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_menu.BackgroundImage")));
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.Controls.Add(this.btn_Tienda);
            this.panel_menu.Controls.Add(this.btn_Inventario);
            this.panel_menu.Controls.Add(this.label5);
            this.panel_menu.Controls.Add(this.btn_Bodega);
            this.panel_menu.Controls.Add(this.btn_IngresarProveedor);
            this.panel_menu.Controls.Add(this.pictureBox2);
            this.panel_menu.Controls.Add(this.btn_Hacerpedido);
            this.panel_menu.Controls.Add(this.btn_AgregarArticulo);
            this.animacion2.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_menu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_menu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_menu.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.panel_menu.GradientTopRight = System.Drawing.Color.White;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Quality = 10;
            this.panel_menu.Size = new System.Drawing.Size(134, 474);
            this.panel_menu.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu1.Controls.Add(this.atras);
            this.menu1.Controls.Add(this.label1);
            this.menu1.Controls.Add(this.panelmenu2);
            this.animacion2.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(858, 45);
            this.menu1.TabIndex = 37;
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
            this.atras.Click += new System.EventHandler(this.atras_Click_1);
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
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventario";
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
            this.panelmenu2.Click += new System.EventHandler(this.panelmenu2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel_menu);
            this.animacion2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 480);
            this.panel2.TabIndex = 38;
            // 
            // animacion2
            // 
            this.animacion2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animacion2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animacion2.DefaultAnimation = animation4;
            // 
            // curva
            // 
            this.curva.ElipseRadius = 5;
            this.curva.TargetControl = this;
            // 
            // MenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(858, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu1);
            this.animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MenuInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelmenu2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition animacion1;
        private BunifuAnimatorNS.BunifuTransition animacion2;
        private Bunifu.Framework.UI.BunifuElipse curva;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Tienda;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventario;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Bodega;
        private Bunifu.Framework.UI.BunifuFlatButton btn_IngresarProveedor;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Hacerpedido;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarArticulo;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel menu1;
        private Bunifu.Framework.UI.BunifuFlatButton atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox panelmenu2;
        private System.Windows.Forms.Panel panel2;
    }
}