
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuInventario MI = new MenuInventario();
            MI.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 220;
            pictureBox1.Height = 120;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = 179;
            pictureBox1.Height = 94;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = 179;
            pictureBox2.Height = 94;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 220;
            pictureBox2.Height = 120;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 179;
            pictureBox3.Height = 94;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 220;
            pictureBox3.Height = 120;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form factu = new facturacion2();
            factu.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reportes R = new Reportes();
            R.Show();
        }
    }
}
