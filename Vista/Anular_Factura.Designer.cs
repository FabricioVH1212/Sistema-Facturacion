namespace Vista
{
    partial class Anular_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anular_Factura));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.animacion3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_NumeroFacturaAnular = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txt_NumeroFacturaAnular);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.listBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(775, 479);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(481, 275);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(72, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 28;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(205, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 134);
            this.listBox1.TabIndex = 27;
            // 
            // animacion3
            // 
            this.animacion3.ElipseRadius = 5;
            this.animacion3.TargetControl = this;
            // 
            // txt_NumeroFacturaAnular
            // 
            this.txt_NumeroFacturaAnular.BackColor = System.Drawing.Color.White;
            this.txt_NumeroFacturaAnular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_NumeroFacturaAnular.BackgroundImage")));
            this.txt_NumeroFacturaAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_NumeroFacturaAnular.ForeColor = System.Drawing.Color.Black;
            this.txt_NumeroFacturaAnular.Icon = ((System.Drawing.Image)(resources.GetObject("txt_NumeroFacturaAnular.Icon")));
            this.txt_NumeroFacturaAnular.Location = new System.Drawing.Point(196, 44);
            this.txt_NumeroFacturaAnular.Name = "txt_NumeroFacturaAnular";
            this.txt_NumeroFacturaAnular.Size = new System.Drawing.Size(366, 42);
            this.txt_NumeroFacturaAnular.TabIndex = 55;
            this.txt_NumeroFacturaAnular.text = "Ingrese el número de factura";
            // 
            // Anular_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(753, 440);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anular_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular_Factura";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuElipse animacion3;
        private Bunifu.Framework.UI.BunifuTextbox txt_NumeroFacturaAnular;
    }
}