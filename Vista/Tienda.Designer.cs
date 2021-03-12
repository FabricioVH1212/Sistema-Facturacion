namespace Vista
{
    partial class Tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tienda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgbt_Descarga = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbt_Descarga)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_Eliminar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Actualizar);
            this.bunifuGradientPanel1.Controls.Add(this.dgbt_Descarga);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
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
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 0;
            this.btn_Eliminar.ButtonText = "Eliminar registro";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Iconimage")));
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 90D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(355, 350);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(177, 48);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar registro";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.Black;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar.BorderRadius = 0;
            this.btn_Actualizar.ButtonText = "Actualizar registro";
            this.btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Actualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Actualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.Iconimage")));
            this.btn_Actualizar.Iconimage_right = null;
            this.btn_Actualizar.Iconimage_right_Selected = null;
            this.btn_Actualizar.Iconimage_Selected = null;
            this.btn_Actualizar.IconMarginLeft = 0;
            this.btn_Actualizar.IconMarginRight = 0;
            this.btn_Actualizar.IconRightVisible = true;
            this.btn_Actualizar.IconRightZoom = 0D;
            this.btn_Actualizar.IconVisible = true;
            this.btn_Actualizar.IconZoom = 90D;
            this.btn_Actualizar.IsTab = false;
            this.btn_Actualizar.Location = new System.Drawing.Point(191, 350);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Actualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Actualizar.selected = false;
            this.btn_Actualizar.Size = new System.Drawing.Size(158, 48);
            this.btn_Actualizar.TabIndex = 4;
            this.btn_Actualizar.Text = "Actualizar registro";
            this.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar.Textcolor = System.Drawing.Color.Black;
            this.btn_Actualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.col_Provincia,
            this.col_Distrito,
            this.col_Canton});
            this.dgbt_Descarga.DoubleBuffered = true;
            this.dgbt_Descarga.EnableHeadersVisualStyles = false;
            this.dgbt_Descarga.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.dgbt_Descarga.HeaderForeColor = System.Drawing.Color.Black;
            this.dgbt_Descarga.Location = new System.Drawing.Point(191, 141);
            this.dgbt_Descarga.Name = "dgbt_Descarga";
            this.dgbt_Descarga.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgbt_Descarga.Size = new System.Drawing.Size(340, 180);
            this.dgbt_Descarga.TabIndex = 3;
            // 
            // col_Provincia
            // 
            this.col_Provincia.HeaderText = "Provincia";
            this.col_Provincia.Name = "col_Provincia";
            // 
            // col_Distrito
            // 
            this.col_Distrito.HeaderText = "Distrito";
            this.col_Distrito.Name = "col_Distrito";
            // 
            // col_Canton
            // 
            this.col_Canton.HeaderText = "Canton";
            this.col_Canton.Name = "col_Canton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de puntos de venta";
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 479);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbt_Descarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Actualizar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgbt_Descarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Canton;
    }
}