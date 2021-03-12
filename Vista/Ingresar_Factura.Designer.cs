namespace Vista
{
    partial class Ingresar_Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresar_Factura));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.txt_Fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgb_Detalle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col_CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animacion2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_GenerarXML = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NuevaFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_IngresarFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabedpane = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbn_Dolares = new System.Windows.Forms.RadioButton();
            this.rbn_Colones = new System.Windows.Forms.RadioButton();
            this.txt_NumeroCedula = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_NumeroFactura = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_NombreCliente = new Bunifu.Framework.UI.BunifuTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Subtotal = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_Impuesto = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_Subtotal = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_GenerarImpuesto = new System.Windows.Forms.Button();
            this.lbx_Total = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgb_Detalle)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.tabedpane.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(516, 152);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Fecha.BorderRadius = 0;
            this.txt_Fecha.ForeColor = System.Drawing.Color.Black;
            this.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_Fecha.FormatCustom = null;
            this.txt_Fecha.Location = new System.Drawing.Point(29, 209);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(366, 44);
            this.txt_Fecha.TabIndex = 1;
            this.txt_Fecha.Value = new System.DateTime(2020, 7, 22, 14, 42, 44, 194);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mostrar factura";
            // 
            // dtgb_Detalle
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgb_Detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgb_Detalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgb_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgb_Detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgb_Detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgb_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgb_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CodigoProducto,
            this.col_NombreProducto,
            this.col_Cantidad,
            this.col_Precio,
            this.col_Importe});
            this.dtgb_Detalle.DoubleBuffered = true;
            this.dtgb_Detalle.EnableHeadersVisualStyles = false;
            this.dtgb_Detalle.GridColor = System.Drawing.Color.Navy;
            this.dtgb_Detalle.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dtgb_Detalle.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgb_Detalle.Location = new System.Drawing.Point(42, 6);
            this.dtgb_Detalle.Name = "dtgb_Detalle";
            this.dtgb_Detalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgb_Detalle.Size = new System.Drawing.Size(543, 233);
            this.dtgb_Detalle.TabIndex = 31;
            this.dtgb_Detalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgb_Detalle_CellEndEdit);
            // 
            // col_CodigoProducto
            // 
            this.col_CodigoProducto.HeaderText = "Código del producto";
            this.col_CodigoProducto.Name = "col_CodigoProducto";
            // 
            // col_NombreProducto
            // 
            this.col_NombreProducto.HeaderText = "Nombre del producto";
            this.col_NombreProducto.Name = "col_NombreProducto";
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.Name = "col_Cantidad";
            // 
            // col_Precio
            // 
            this.col_Precio.HeaderText = "Precio";
            this.col_Precio.Name = "col_Precio";
            // 
            // col_Importe
            // 
            this.col_Importe.HeaderText = "Importe";
            this.col_Importe.Name = "col_Importe";
            // 
            // animacion2
            // 
            this.animacion2.ElipseRadius = 5;
            this.animacion2.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_GenerarXML);
            this.bunifuGradientPanel1.Controls.Add(this.btn_NuevaFactura);
            this.bunifuGradientPanel1.Controls.Add(this.btn_IngresarFactura);
            this.bunifuGradientPanel1.Controls.Add(this.tabedpane);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(769, 479);
            this.bunifuGradientPanel1.TabIndex = 33;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btn_GenerarXML
            // 
            this.btn_GenerarXML.Activecolor = System.Drawing.Color.Transparent;
            this.btn_GenerarXML.BackColor = System.Drawing.Color.Transparent;
            this.btn_GenerarXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GenerarXML.BorderRadius = 0;
            this.btn_GenerarXML.ButtonText = "Generar XML";
            this.btn_GenerarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerarXML.DisabledColor = System.Drawing.Color.Gray;
            this.btn_GenerarXML.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_GenerarXML.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_GenerarXML.Iconimage")));
            this.btn_GenerarXML.Iconimage_right = null;
            this.btn_GenerarXML.Iconimage_right_Selected = null;
            this.btn_GenerarXML.Iconimage_Selected = null;
            this.btn_GenerarXML.IconMarginLeft = 0;
            this.btn_GenerarXML.IconMarginRight = 0;
            this.btn_GenerarXML.IconRightVisible = true;
            this.btn_GenerarXML.IconRightZoom = 0D;
            this.btn_GenerarXML.IconVisible = true;
            this.btn_GenerarXML.IconZoom = 90D;
            this.btn_GenerarXML.IsTab = false;
            this.btn_GenerarXML.Location = new System.Drawing.Point(304, 374);
            this.btn_GenerarXML.Name = "btn_GenerarXML";
            this.btn_GenerarXML.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_GenerarXML.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_GenerarXML.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_GenerarXML.selected = false;
            this.btn_GenerarXML.Size = new System.Drawing.Size(134, 48);
            this.btn_GenerarXML.TabIndex = 59;
            this.btn_GenerarXML.Text = "Generar XML";
            this.btn_GenerarXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerarXML.Textcolor = System.Drawing.Color.Black;
            this.btn_GenerarXML.TextFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarXML.Click += new System.EventHandler(this.btn_GenerarXML_Click);
            // 
            // btn_NuevaFactura
            // 
            this.btn_NuevaFactura.Activecolor = System.Drawing.Color.Transparent;
            this.btn_NuevaFactura.BackColor = System.Drawing.Color.Transparent;
            this.btn_NuevaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NuevaFactura.BorderRadius = 0;
            this.btn_NuevaFactura.ButtonText = "Nueva factura";
            this.btn_NuevaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NuevaFactura.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NuevaFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NuevaFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_NuevaFactura.Iconimage")));
            this.btn_NuevaFactura.Iconimage_right = null;
            this.btn_NuevaFactura.Iconimage_right_Selected = null;
            this.btn_NuevaFactura.Iconimage_Selected = null;
            this.btn_NuevaFactura.IconMarginLeft = 0;
            this.btn_NuevaFactura.IconMarginRight = 0;
            this.btn_NuevaFactura.IconRightVisible = true;
            this.btn_NuevaFactura.IconRightZoom = 0D;
            this.btn_NuevaFactura.IconVisible = true;
            this.btn_NuevaFactura.IconZoom = 90D;
            this.btn_NuevaFactura.IsTab = false;
            this.btn_NuevaFactura.Location = new System.Drawing.Point(29, 374);
            this.btn_NuevaFactura.Name = "btn_NuevaFactura";
            this.btn_NuevaFactura.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_NuevaFactura.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_NuevaFactura.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NuevaFactura.selected = false;
            this.btn_NuevaFactura.Size = new System.Drawing.Size(109, 48);
            this.btn_NuevaFactura.TabIndex = 58;
            this.btn_NuevaFactura.Text = "Nueva factura";
            this.btn_NuevaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevaFactura.Textcolor = System.Drawing.Color.Black;
            this.btn_NuevaFactura.TextFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaFactura.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_IngresarFactura
            // 
            this.btn_IngresarFactura.Activecolor = System.Drawing.Color.Transparent;
            this.btn_IngresarFactura.BackColor = System.Drawing.Color.Transparent;
            this.btn_IngresarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IngresarFactura.BorderRadius = 0;
            this.btn_IngresarFactura.ButtonText = "Ingresar factura";
            this.btn_IngresarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresarFactura.DisabledColor = System.Drawing.Color.Gray;
            this.btn_IngresarFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_IngresarFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_IngresarFactura.Iconimage")));
            this.btn_IngresarFactura.Iconimage_right = null;
            this.btn_IngresarFactura.Iconimage_right_Selected = null;
            this.btn_IngresarFactura.Iconimage_Selected = null;
            this.btn_IngresarFactura.IconMarginLeft = 0;
            this.btn_IngresarFactura.IconMarginRight = 0;
            this.btn_IngresarFactura.IconRightVisible = true;
            this.btn_IngresarFactura.IconRightZoom = 0D;
            this.btn_IngresarFactura.IconVisible = true;
            this.btn_IngresarFactura.IconZoom = 90D;
            this.btn_IngresarFactura.IsTab = false;
            this.btn_IngresarFactura.Location = new System.Drawing.Point(570, 374);
            this.btn_IngresarFactura.Name = "btn_IngresarFactura";
            this.btn_IngresarFactura.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_IngresarFactura.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_IngresarFactura.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_IngresarFactura.selected = false;
            this.btn_IngresarFactura.Size = new System.Drawing.Size(109, 48);
            this.btn_IngresarFactura.TabIndex = 57;
            this.btn_IngresarFactura.Text = "Ingresar factura";
            this.btn_IngresarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IngresarFactura.Textcolor = System.Drawing.Color.Black;
            this.btn_IngresarFactura.TextFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabedpane
            // 
            this.tabedpane.Controls.Add(this.tabPage1);
            this.tabedpane.Controls.Add(this.tabPage2);
            this.tabedpane.Controls.Add(this.tabPage3);
            this.tabedpane.Location = new System.Drawing.Point(25, 51);
            this.tabedpane.Name = "tabedpane";
            this.tabedpane.SelectedIndex = 0;
            this.tabedpane.Size = new System.Drawing.Size(654, 305);
            this.tabedpane.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbn_Dolares);
            this.tabPage1.Controls.Add(this.rbn_Colones);
            this.tabPage1.Controls.Add(this.txt_NumeroCedula);
            this.tabPage1.Controls.Add(this.txt_NumeroFactura);
            this.tabPage1.Controls.Add(this.txt_NombreCliente);
            this.tabPage1.Controls.Add(this.txt_Fecha);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de datos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(515, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(441, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo de cambio";
            // 
            // rbn_Dolares
            // 
            this.rbn_Dolares.AutoSize = true;
            this.rbn_Dolares.Location = new System.Drawing.Point(446, 142);
            this.rbn_Dolares.Name = "rbn_Dolares";
            this.rbn_Dolares.Size = new System.Drawing.Size(61, 17);
            this.rbn_Dolares.TabIndex = 57;
            this.rbn_Dolares.TabStop = true;
            this.rbn_Dolares.Text = "Dolares";
            this.rbn_Dolares.UseVisualStyleBackColor = true;
            this.rbn_Dolares.CheckedChanged += new System.EventHandler(this.rbn_Dolares_CheckedChanged);
            // 
            // rbn_Colones
            // 
            this.rbn_Colones.AutoSize = true;
            this.rbn_Colones.Location = new System.Drawing.Point(446, 76);
            this.rbn_Colones.Name = "rbn_Colones";
            this.rbn_Colones.Size = new System.Drawing.Size(63, 17);
            this.rbn_Colones.TabIndex = 56;
            this.rbn_Colones.TabStop = true;
            this.rbn_Colones.Text = "Colones";
            this.rbn_Colones.UseVisualStyleBackColor = true;
            this.rbn_Colones.Click += new System.EventHandler(this.rbn_Colones_Click);
            // 
            // txt_NumeroCedula
            // 
            this.txt_NumeroCedula.BackColor = System.Drawing.Color.White;
            this.txt_NumeroCedula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_NumeroCedula.BackgroundImage")));
            this.txt_NumeroCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_NumeroCedula.ForeColor = System.Drawing.Color.Black;
            this.txt_NumeroCedula.Icon = ((System.Drawing.Image)(resources.GetObject("txt_NumeroCedula.Icon")));
            this.txt_NumeroCedula.Location = new System.Drawing.Point(29, 76);
            this.txt_NumeroCedula.Name = "txt_NumeroCedula";
            this.txt_NumeroCedula.Size = new System.Drawing.Size(366, 42);
            this.txt_NumeroCedula.TabIndex = 55;
            this.txt_NumeroCedula.text = "Número de cedúla";
            // 
            // txt_NumeroFactura
            // 
            this.txt_NumeroFactura.BackColor = System.Drawing.Color.White;
            this.txt_NumeroFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_NumeroFactura.BackgroundImage")));
            this.txt_NumeroFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_NumeroFactura.ForeColor = System.Drawing.Color.Black;
            this.txt_NumeroFactura.Icon = ((System.Drawing.Image)(resources.GetObject("txt_NumeroFactura.Icon")));
            this.txt_NumeroFactura.Location = new System.Drawing.Point(29, 18);
            this.txt_NumeroFactura.Name = "txt_NumeroFactura";
            this.txt_NumeroFactura.Size = new System.Drawing.Size(366, 42);
            this.txt_NumeroFactura.TabIndex = 54;
            this.txt_NumeroFactura.text = "Número de factura";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BackColor = System.Drawing.Color.White;
            this.txt_NombreCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_NombreCliente.BackgroundImage")));
            this.txt_NombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_NombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txt_NombreCliente.Icon = ((System.Drawing.Image)(resources.GetObject("txt_NombreCliente.Icon")));
            this.txt_NombreCliente.Location = new System.Drawing.Point(29, 142);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(366, 42);
            this.txt_NombreCliente.TabIndex = 52;
            this.txt_NombreCliente.text = "Nombre del cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.btn_Subtotal);
            this.tabPage2.Controls.Add(this.dtgb_Detalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // btn_Subtotal
            // 
            this.btn_Subtotal.Location = new System.Drawing.Point(486, 245);
            this.btn_Subtotal.Name = "btn_Subtotal";
            this.btn_Subtotal.Size = new System.Drawing.Size(99, 23);
            this.btn_Subtotal.TabIndex = 32;
            this.btn_Subtotal.Text = "Calcular subtotal";
            this.btn_Subtotal.UseVisualStyleBackColor = true;
            this.btn_Subtotal.Click += new System.EventHandler(this.btn_Subtotal_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Impuesto";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.txt_Impuesto);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Subtotal);
            this.splitContainer1.Panel1.Controls.Add(this.btn_GenerarImpuesto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.splitContainer1.Panel2.Controls.Add(this.lbx_Total);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(634, 236);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 32;
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.BackColor = System.Drawing.Color.White;
            this.txt_Impuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Impuesto.BackgroundImage")));
            this.txt_Impuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Impuesto.ForeColor = System.Drawing.Color.Black;
            this.txt_Impuesto.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Impuesto.Icon")));
            this.txt_Impuesto.Location = new System.Drawing.Point(16, 132);
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.Size = new System.Drawing.Size(187, 42);
            this.txt_Impuesto.TabIndex = 62;
            this.txt_Impuesto.text = "Impuesto";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.BackColor = System.Drawing.Color.White;
            this.txt_Subtotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Subtotal.BackgroundImage")));
            this.txt_Subtotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Subtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_Subtotal.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Subtotal.Icon")));
            this.txt_Subtotal.Location = new System.Drawing.Point(16, 39);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(187, 42);
            this.txt_Subtotal.TabIndex = 61;
            this.txt_Subtotal.text = "Subtotal";
            // 
            // btn_GenerarImpuesto
            // 
            this.btn_GenerarImpuesto.Location = new System.Drawing.Point(99, 195);
            this.btn_GenerarImpuesto.Name = "btn_GenerarImpuesto";
            this.btn_GenerarImpuesto.Size = new System.Drawing.Size(104, 23);
            this.btn_GenerarImpuesto.TabIndex = 32;
            this.btn_GenerarImpuesto.Text = "Generar impuesto";
            this.btn_GenerarImpuesto.UseVisualStyleBackColor = true;
            this.btn_GenerarImpuesto.Click += new System.EventHandler(this.btn_GenerarImpuesto_Click);
            // 
            // lbx_Total
            // 
            this.lbx_Total.BackColor = System.Drawing.Color.White;
            this.lbx_Total.ForeColor = System.Drawing.Color.Black;
            this.lbx_Total.FormattingEnabled = true;
            this.lbx_Total.Location = new System.Drawing.Point(-5, 49);
            this.lbx_Total.Name = "lbx_Total";
            this.lbx_Total.Size = new System.Drawing.Size(390, 186);
            this.lbx_Total.TabIndex = 31;
            this.lbx_Total.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_Total_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(155, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 41);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total";
            // 
            // Ingresar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(769, 479);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar factura";
            this.Load += new System.EventHandler(this.Ingresar_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgb_Detalle)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.tabedpane.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private Bunifu.Framework.UI.BunifuDatepicker txt_Fecha;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgb_Detalle;
        private Bunifu.Framework.UI.BunifuElipse animacion2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TabControl tabedpane;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbx_Total;
        private System.Windows.Forms.Button btn_Subtotal;
        private System.Windows.Forms.Button btn_GenerarImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Importe;
        private Bunifu.Framework.UI.BunifuTextbox txt_NombreCliente;
        private Bunifu.Framework.UI.BunifuTextbox txt_NumeroCedula;
        private Bunifu.Framework.UI.BunifuTextbox txt_NumeroFactura;
        private Bunifu.Framework.UI.BunifuFlatButton btn_IngresarFactura;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbn_Dolares;
        private System.Windows.Forms.RadioButton rbn_Colones;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NuevaFactura;
        private Bunifu.Framework.UI.BunifuTextbox txt_Subtotal;
        private Bunifu.Framework.UI.BunifuTextbox txt_Impuesto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_GenerarXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}