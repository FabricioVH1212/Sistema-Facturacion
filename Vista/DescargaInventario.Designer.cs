namespace Vista
{
    partial class DescargaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescargaInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgbt_Descarga = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Articulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_BuscarCliente = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbt_Descarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_BuscarCliente);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.dgbt_Descarga);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(769, 479);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // dgbt_Descarga
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbt_Descarga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbt_Descarga.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgbt_Descarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbt_Descarga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbt_Descarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbt_Descarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbt_Descarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Cliente,
            this.col_Descargas,
            this.col_Articulos});
            this.dgbt_Descarga.DoubleBuffered = true;
            this.dgbt_Descarga.EnableHeadersVisualStyles = false;
            this.dgbt_Descarga.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.dgbt_Descarga.HeaderForeColor = System.Drawing.Color.Black;
            this.dgbt_Descarga.Location = new System.Drawing.Point(201, 189);
            this.dgbt_Descarga.Name = "dgbt_Descarga";
            this.dgbt_Descarga.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgbt_Descarga.Size = new System.Drawing.Size(340, 180);
            this.dgbt_Descarga.TabIndex = 0;
            // 
            // col_Cliente
            // 
            this.col_Cliente.HeaderText = "Nombre del cliente";
            this.col_Cliente.Name = "col_Cliente";
            // 
            // col_Descargas
            // 
            this.col_Descargas.HeaderText = "Cantidad de descargas";
            this.col_Descargas.Name = "col_Descargas";
            // 
            // col_Articulos
            // 
            this.col_Articulos.HeaderText = "Artículos";
            this.col_Articulos.Name = "col_Articulos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de descargas del inventario";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(485, 141);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 5;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackColor = System.Drawing.Color.Silver;
            this.btn_BuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCliente.BackgroundImage")));
            this.btn_BuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btn_BuscarCliente.Icon = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCliente.Icon")));
            this.btn_BuscarCliente.Location = new System.Drawing.Point(201, 141);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(278, 42);
            this.btn_BuscarCliente.TabIndex = 4;
            this.btn_BuscarCliente.text = "Buscar cliente";
            // 
            // DescargaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 479);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescargaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DescargaInventario";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbt_Descarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgbt_Descarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Articulos;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTextbox btn_BuscarCliente;
    }
}