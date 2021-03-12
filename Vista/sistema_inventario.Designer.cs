namespace Vista
{
    partial class sistema_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistema_inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grupo_inv = new System.Windows.Forms.GroupBox();
            this.buscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cargar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inventario = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grupo_inv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 461);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grupo_inv);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(765, 428);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grupo_inv
            // 
            this.grupo_inv.BackColor = System.Drawing.Color.Transparent;
            this.grupo_inv.Controls.Add(this.txt_Buscar);
            this.grupo_inv.Controls.Add(this.buscar);
            this.grupo_inv.Controls.Add(this.cargar);
            this.grupo_inv.Controls.Add(this.inventario);
            this.grupo_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_inv.Location = new System.Drawing.Point(33, 24);
            this.grupo_inv.Name = "grupo_inv";
            this.grupo_inv.Size = new System.Drawing.Size(633, 378);
            this.grupo_inv.TabIndex = 0;
            this.grupo_inv.TabStop = false;
            this.grupo_inv.Text = "Inventario";
            // 
            // buscar
            // 
            this.buscar.Activecolor = System.Drawing.Color.Transparent;
            this.buscar.BackColor = System.Drawing.Color.Transparent;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscar.BorderRadius = 0;
            this.buscar.ButtonText = "";
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.DisabledColor = System.Drawing.Color.Gray;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Iconcolor = System.Drawing.Color.Transparent;
            this.buscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("buscar.Iconimage")));
            this.buscar.Iconimage_right = null;
            this.buscar.Iconimage_right_Selected = null;
            this.buscar.Iconimage_Selected = null;
            this.buscar.IconMarginLeft = 0;
            this.buscar.IconMarginRight = 0;
            this.buscar.IconRightVisible = true;
            this.buscar.IconRightZoom = 0D;
            this.buscar.IconVisible = true;
            this.buscar.IconZoom = 75D;
            this.buscar.IsTab = false;
            this.buscar.Location = new System.Drawing.Point(600, 81);
            this.buscar.Margin = new System.Windows.Forms.Padding(7);
            this.buscar.Name = "buscar";
            this.buscar.Normalcolor = System.Drawing.Color.Transparent;
            this.buscar.OnHovercolor = System.Drawing.Color.Transparent;
            this.buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.buscar.selected = false;
            this.buscar.Size = new System.Drawing.Size(41, 35);
            this.buscar.TabIndex = 3;
            this.buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.Textcolor = System.Drawing.Color.Black;
            this.buscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // cargar
            // 
            this.cargar.Activecolor = System.Drawing.Color.Transparent;
            this.cargar.BackColor = System.Drawing.Color.Transparent;
            this.cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar.BorderRadius = 0;
            this.cargar.ButtonText = "Cargar inventario";
            this.cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargar.DisabledColor = System.Drawing.Color.Gray;
            this.cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Iconcolor = System.Drawing.Color.Transparent;
            this.cargar.Iconimage = ((System.Drawing.Image)(resources.GetObject("cargar.Iconimage")));
            this.cargar.Iconimage_right = null;
            this.cargar.Iconimage_right_Selected = null;
            this.cargar.Iconimage_Selected = null;
            this.cargar.IconMarginLeft = 0;
            this.cargar.IconMarginRight = 0;
            this.cargar.IconRightVisible = true;
            this.cargar.IconRightZoom = 0D;
            this.cargar.IconVisible = true;
            this.cargar.IconZoom = 66D;
            this.cargar.IsTab = false;
            this.cargar.Location = new System.Drawing.Point(112, 316);
            this.cargar.Margin = new System.Windows.Forms.Padding(7);
            this.cargar.Name = "cargar";
            this.cargar.Normalcolor = System.Drawing.Color.Transparent;
            this.cargar.OnHovercolor = System.Drawing.Color.Transparent;
            this.cargar.OnHoverTextColor = System.Drawing.Color.White;
            this.cargar.selected = false;
            this.cargar.Size = new System.Drawing.Size(166, 39);
            this.cargar.TabIndex = 1;
            this.cargar.Text = "Cargar inventario";
            this.cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargar.Textcolor = System.Drawing.Color.Black;
            this.cargar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // inventario
            // 
            this.inventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventario.Location = new System.Drawing.Point(17, 34);
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(366, 273);
            this.inventario.TabIndex = 0;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.Silver;
            this.txt_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.BackgroundImage")));
            this.txt_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_Buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Buscar.Icon")));
            this.txt_Buscar.Location = new System.Drawing.Point(393, 81);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(193, 37);
            this.txt_Buscar.TabIndex = 5;
            this.txt_Buscar.text = "Buscar";
            // 
            // sistema_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(766, 429);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sistema_inventario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.grupo_inv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grupo_inv;
        private Bunifu.Framework.UI.BunifuFlatButton cargar;
        private System.Windows.Forms.DataGridView inventario;
        private Bunifu.Framework.UI.BunifuFlatButton buscar;
        private Bunifu.Framework.UI.BunifuTextbox txt_Buscar;
    }
}