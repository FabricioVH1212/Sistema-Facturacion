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
    public partial class Ingresar_Cliente : Form
    {
        ToolTip informacion = new ToolTip();
        public Ingresar_Cliente()
        {
            InitializeComponent();
            
        //panel_menu(new Ingresar_fac);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_NuevoCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea ingresar un nuevo cliente?", "Ingresar Cliente", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                txtNombre._TextBox.Text = "Nombre";
                txtApe1._TextBox.Text = "Primer Apellido";
                txtApe2._TextBox.Text = "Segundo Apellido";
                txtTelefono._TextBox.Text = "Teléfono";
                txtdireccion._TextBox.Text = "Dirección";
                txtCorreo._TextBox.Text = "Correo eléctronico";
               
            }
        }
    }
}
