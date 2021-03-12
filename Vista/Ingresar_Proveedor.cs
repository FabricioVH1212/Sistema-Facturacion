using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Ingresar_Proveedor : Form
    {
        public Ingresar_Proveedor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea ingresar un nuevo proveedor?", "Ingresar proveedor", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                txt_NombreProveedor._TextBox.Text = "Nombre Proveedor";
                txt_CodigoProveedor._TextBox.Text = "Código Proveedor";
                txt_DireccionProveedor._TextBox.Text = "Dirección Proveedor";
                txt_DetalleProveedor._TextBox.Text = "Detalle Proveedor";
                txt_TelefonoProveedor._TextBox.Text = "Teléfono Proveedor";
                txt_CodigoArticuloPro._TextBox.Text = "Código artículo";

            }

        }
    }
}
