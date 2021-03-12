using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
 

namespace Vista
{
    public partial class Ingresar_Factura : Form
    {
        DialogResult dlgRes;
        string TipoCambio , NombreProducto;
        int Cod_Producto;
        double Cantidad, Precio, Importe, Impuesto = 0, ConvertirImpuesto, Total;
        double subtotal = 0;
      
        public Ingresar_Factura()
        {
            InitializeComponent();
        }
        
        private void Ingresar_Factura_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void dtgb_Detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Multiplicación de precio y cantidad de articulos entre sí.
                

                Cantidad = Convert.ToInt32(dtgb_Detalle.Rows[e.RowIndex].Cells["col_Cantidad"].Value);
                Precio = Convert.ToInt32(dtgb_Detalle.Rows[e.RowIndex].Cells["col_Precio"].Value);
         

                Importe = Cantidad * Precio;

                dtgb_Detalle.Rows[e.RowIndex].Cells["col_Importe"].Value = Importe;

            }
            catch (Exception)
            {
                MessageBox.Show("Algun dato ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double SumaColumna(string NombreCol)
        {
            try
            {

                foreach (DataGridViewRow row in dtgb_Detalle.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells[NombreCol].Value);
                }
                return subtotal;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al sumar las columnas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return subtotal;
        }

        private void rbn_Colones_Click(object sender, EventArgs e)
        {
              TipoCambio = rbn_Colones.Text;
     
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea realizar una nueva factura?", "Ingresar factura",MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                txt_NumeroFactura._TextBox.Text = "Número de factura";
                txt_NumeroCedula._TextBox.Text = "Número de cedúla";
                txt_NombreCliente._TextBox.Text = "Nombre del cliente";
                dtgb_Detalle.Rows.Clear();
                txt_Subtotal._TextBox.Text = "Subtotal";
                txt_Impuesto._TextBox.Text = "Impuesto";
                lbx_Total.Items.Clear();
               
            }
        }

        private void btn_GenerarXML_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "XML-File | *.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK);
                {
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);
                    XmlElement Factura = doc.CreateElement(string.Empty, "Factura", string.Empty);
                    doc.AppendChild(Factura);

                    XmlElement element2 = doc.CreateElement(string.Empty, "nivel", string.Empty);
                    Factura.AppendChild(element2);

                    XmlElement element3 = doc.CreateElement(string.Empty, "NúmeroDeFactura", string.Empty);
                    XmlText text1 = doc.CreateTextNode(txt_NumeroFactura._TextBox.Text);
                    element3.AppendChild(text1);
                    element2.AppendChild(element3);

                    XmlElement element4 = doc.CreateElement(string.Empty, "NúmeroDeCedúla", string.Empty);
                    XmlText text2 = doc.CreateTextNode(txt_NumeroCedula._TextBox.Text);
                    element4.AppendChild(text2);
                    element2.AppendChild(element4);

                    XmlElement element5 = doc.CreateElement(string.Empty, "NombreDelCliente", string.Empty);
                    XmlText text3 = doc.CreateTextNode(txt_NombreCliente._TextBox.Text);
                    element5.AppendChild(text3);
                    element2.AppendChild(element5);

                    XmlElement element6 = doc.CreateElement(string.Empty, "Fecha", string.Empty);
                    XmlText text4 = doc.CreateTextNode(Convert.ToString(txt_Fecha.Value.Date));
                    element6.AppendChild(text4);
                    element2.AppendChild(element6);

                    XmlElement element7 = doc.CreateElement(string.Empty, "TipoDeCambio", string.Empty);
                    XmlText text5 = doc.CreateTextNode(TipoCambio);
                    element7.AppendChild(text5);
                    element2.AppendChild(element7);

                    XmlElement element8 = doc.CreateElement(string.Empty, "Subtotal", string.Empty);
                    XmlText text6 = doc.CreateTextNode(Convert.ToString(subtotal));
                    element8.AppendChild(text6);
                    element2.AppendChild(element8);

                    XmlElement element9 = doc.CreateElement(string.Empty, "Impuesto", string.Empty);
                    XmlText text7 = doc.CreateTextNode(Convert.ToString(ConvertirImpuesto));
                    element9.AppendChild(text7);
                    element2.AppendChild(element9);

                    XmlElement element10 = doc.CreateElement(string.Empty, "Total", string.Empty);
                    XmlText text8 = doc.CreateTextNode(Convert.ToString(Total));
                    element10.AppendChild(text8);
                    element2.AppendChild(element10);

                    doc.Save(saveFileDialog1.FileName);
                 
                    MessageBox.Show("Guardado con éxito", "Guardar");
                }
              
            }
            catch (Exception ex)
            {
               MessageBox.Show("Algun dato ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rbn_Dolares_CheckedChanged(object sender, EventArgs e)
        {
            TipoCambio = rbn_Dolares.Text;
        }

        private void btn_Subtotal_Click(object sender, EventArgs e)
        {
            //Esta calcula la suma de todos los precios de compra del cliente
            try
            {
               dtgb_Detalle.Rows.Add("Subtotal", "", "", SumaColumna("col_Importe"));
               txt_Subtotal._TextBox.Text = Convert.ToString(subtotal);
               dtgb_Detalle.ReadOnly = false;
             
            }
            catch (Exception)
            {
                MessageBox.Show("Alguno de los datos ingresados no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_GenerarImpuesto_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Generación de impuesto
                ConvertirImpuesto = Convert.ToDouble(txt_Impuesto._TextBox.Text) / 100;
                Impuesto = subtotal * ConvertirImpuesto;
                Total = subtotal + Impuesto;
                
                MessageBox.Show("Impuesto generado exitosamente");

                lbx_Total.Items.Add("Facturación ");
                lbx_Total.Items.Add("Número de factura = " + txt_NumeroFactura._TextBox.Text);
                lbx_Total.Items.Add("Número de cedúla = " + txt_NumeroCedula._TextBox.Text);
                lbx_Total.Items.Add("Nombre del cliente = " + txt_NombreCliente._TextBox.Text);
                lbx_Total.Items.Add("Fecha = " + txt_Fecha.Value.Date);
                lbx_Total.Items.Add("Tipo de cambio = " + TipoCambio);
                lbx_Total.Items.Add(dtgb_Detalle.CurrentRow.Cells["col_CodigoProducto"].Value.ToString());
                lbx_Total.Items.Add("Precio = " +Precio);
                lbx_Total.Items.Add("Importe = " + Importe);
                lbx_Total.Items.Add("Subtotal = " + subtotal);
                lbx_Total.Items.Add("Impuesto = " + ConvertirImpuesto);
                lbx_Total.Items.Add("Total = " + Total);
            }
            catch
            {
                MessageBox.Show("Alguno de los datos ingresados no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void lbx_Total_MouseDoubleClick(object sender, MouseEventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
