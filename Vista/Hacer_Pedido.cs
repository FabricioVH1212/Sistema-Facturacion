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
    public partial class Hacer_Pedido : Form
    {
        public Hacer_Pedido()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Nuevopedido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea ingresar un nuevo cliente?", "Ingresar Cliente", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                txt_CodigoPedido._TextBox.Text = "Código del pedido";
                txt_CodigoArticuloP._TextBox.Text = "Código del artículo";
                txt_CodigoProveedor._TextBox.Text = "Código del proveedor";
                txt_CodigoInventarioP._TextBox.Text = "Código del inventario";
                txt_CantidadArticuloPedido._TextBox.Text = "Cantidad del artículo";
                txt_PuntodeReorden._TextBox.Text = "Punto de reorden";

            }
        }
    }
}
