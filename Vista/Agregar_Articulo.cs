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
    public partial class Agregar_Articulo : Form
    {
        public Agregar_Articulo()
        {
            InitializeComponent();
        }

        private void btn_NuevoArticulo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea ingresar un nuevo cliente?", "Ingresar Cliente", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                txt_CodigoArticulo._TextBox.Text = "Código del artículo";
                txt_NombreArticulo._TextBox.Text = "Nombre del artículo";
                txt_PrecioCosto._TextBox.Text = "Precio costo";
                txt_PrecioVenta._TextBox.Text = "Precio venta";
                txt_Estado._TextBox.Text = "Estado";

            }
        }
    }
}
