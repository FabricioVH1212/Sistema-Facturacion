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
    public partial class MenuInventario : Form
    {
        
        public MenuInventario()
        {
            InitializeComponent();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_AgregarArticulo_Click(object sender, EventArgs e)
        {
            Agregar_Articulo AT = new Agregar_Articulo();
            AT.MdiParent = this;
            AT.Show();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            DescargaInventario DI = new DescargaInventario();
            DI.MdiParent = this;
            DI.Show();
        }

        private void btn_Hacerpedido_Click(object sender, EventArgs e)
        {
            Hacer_Pedido HP = new Hacer_Pedido();
            HP.MdiParent = this;
            HP.Show();

        }

        private void btn_Bodega_Click(object sender, EventArgs e)
        {
            Bodega BD = new Bodega();
            BD.MdiParent = this;
            BD.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            //Form ini = new Menu();
            //ini.Show();
            //Application.Exit();
            this.Hide();
        }

        private void inve_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void inve_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_AgregarArticulo_Click_1(object sender, EventArgs e)
        {
            //IC.MdiParent = this;
            //IC.Show();
        }

        private void btn_IngresarProveedor_Click(object sender, EventArgs e)
        {
            Ingresar_Proveedor IP = new Ingresar_Proveedor();
            IP.MdiParent = this;
            IP.Show();
        }

        private void atras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panelmenu2_Click_1(object sender, EventArgs e)
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

        private void btn_Tienda_Click(object sender, EventArgs e)
        {
            Tienda T = new Tienda();
            T.MdiParent = this;
            T.Show();
        }
    }
}
