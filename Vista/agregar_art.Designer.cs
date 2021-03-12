namespace Vista
{
    partial class agregar_art
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_art));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.nuev_articulo = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cant_articulos = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.cant_articulos);
            this.bunifuGradientPanel1.Controls.Add(this.nuev_articulo);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(31, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(691, 435);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // nuev_articulo
            // 
            this.nuev_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nuev_articulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nuev_articulo.BackgroundImage")));
            this.nuev_articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuev_articulo.ForeColor = System.Drawing.Color.Blue;
            this.nuev_articulo.Icon = ((System.Drawing.Image)(resources.GetObject("nuev_articulo.Icon")));
            this.nuev_articulo.Location = new System.Drawing.Point(36, 86);
            this.nuev_articulo.Name = "nuev_articulo";
            this.nuev_articulo.Size = new System.Drawing.Size(238, 33);
            this.nuev_articulo.TabIndex = 2;
            this.nuev_articulo.text = "Nuevo Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Articulo";
            // 
            // cant_articulos
            // 
            this.cant_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cant_articulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cant_articulos.BackgroundImage")));
            this.cant_articulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cant_articulos.ForeColor = System.Drawing.Color.Blue;
            this.cant_articulos.Icon = ((System.Drawing.Image)(resources.GetObject("cant_articulos.Icon")));
            this.cant_articulos.Location = new System.Drawing.Point(36, 145);
            this.cant_articulos.Name = "cant_articulos";
            this.cant_articulos.Size = new System.Drawing.Size(238, 33);
            this.cant_articulos.TabIndex = 3;
            this.cant_articulos.text = "Cantidad";
            // 
            // agregar_art
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(769, 479);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregar_art";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregar_art";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox nuev_articulo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox cant_articulos;
    }
}