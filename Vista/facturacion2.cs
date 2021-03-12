using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
namespace Vista
{
    public partial class facturacion2 : Form
    {
       
        public facturacion2()
        {
            InitializeComponent();

             
        }
        //private void AbrirFormulario<T>() where T : Form, new()
        //{
        //    Form formulario = ingresar_fac.Controls.OfType<T>().FirstOrDefault();
        //    if (formulario != null)
        //    {
        //        //Si la instancia esta minimizada la dejamos en su estado normal
        //        if (formulario.WindowState == FormWindowState.Minimized)
        //        {
        //            formulario.WindowState = FormWindowState.Normal;
        //        }
        //        //Si la instancia existe la pongo en primer plano
        //        formulario.BringToFront();
        //        return;
        //    }
        //    //Se abre el form
        //    formulario = new T();
        //    formulario.TopLevel = false;
        //    panel_prin.Controls.Add(formulario);
        //    panel_prin.Tag = formulario;
        //    formulario.Show();
        //}


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //AbrirFormulario<ingresar_fac2>();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void cargar_inventario_Click(object sender, EventArgs e)
        {
            sistema_inventario fr = new sistema_inventario();
            fr.MdiParent = this;
            fr.Show();
        }

        private void panelmenu2_Click(object sender, EventArgs e)
        {
           if (panel_menu.Width == 122)
            {
                panel_menu.Visible = false;
                panel_menu.Width = 57;
                panel2.Width = 70;
                animacion1.Show(panel_menu);
            }
            else
            {
                panel_menu.Visible = false;
                panel_menu.Width = 122;
                panel2.Width = 141;
                animacion2.Show(panel_menu);
                //panel_menu.Width == 122;

                //_ = panelmenu2.Width == 141;

            }
        }
       
        private void ingresar_fac_Click(object sender, EventArgs e)
        {
          
            Ingresar_Factura IC = new Ingresar_Factura(); 
            IC.MdiParent = this;
            IC.Show();
           
            //panel_menu(new formIngresar_fac);
        }

        private void panel_forms_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {
            //panel_forms.Controls.Add(panel_menu);
            //panel_forms.Tag = panel_menu;
            //panel_menu.BringToFront();
            //panel_menu.Show();
        }

        private void menu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_prin_Paint(object sender, PaintEventArgs e)
        {
            //ingresar_fac<ingresar_fac2>();
        }

        private void ingresar_clien_Click(object sender, EventArgs e)
        {
            Ingresar_Cliente IC = new Ingresar_Cliente();
            IC.MdiParent = this;
            IC.Show();
        }

        private void anular_fac_Click(object sender, EventArgs e)
        {
            Anular_Factura AF = new Anular_Factura();
            AF.MdiParent = this;
            AF.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
