using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPOO2
{
    public partial class Diesel : Form
    {
        public Diesel()
        {
            InitializeComponent();
        }



        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (rbGalones.Checked == true)
            {
                panelgalones.Show();
                panelefectivo.Visible = false;
                panelpagarefectivo.Visible = false;
            }
       

            if (rbEfectivo.Checked == true)
            {
                panelefectivo.Show();
                panelgalones.Visible = false;
                panelpagargalones.Visible = false;
            }

           
            

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu2 fmrs4 = new Menu2();
            fmrs4.Show();
            this.Hide();
        }

        private void Diesel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIrGalonesDiesel_Click(object sender, EventArgs e)
        {
            panelpagargalones.Show();
            double galones;
            double dinero;
            double galon = 4.25;
            galones = Convert.ToDouble(txtgalonesdiesel.Text);
            dinero = galon * galones;


            txtdinerogalonesdiesel.Text = dinero.ToString();
        }


        private void btnIrGalonesEfectivo_Click(object sender, EventArgs e)
        {
            panelpagarefectivo.Show();

            
             double galones;
              double dinero;
              double galon = 4.25;
              dinero = Convert.ToDouble(Txtefectivo.Text);
              galones = dinero / galon;   
         
           
           txtgalonesrecibidosdiesel.Text = Math.Round(galones, 2).ToString(); 

            


            double efectivo;


            efectivo = Convert.ToDouble(Txtefectivo.Text);

            txtdinero.Text = efectivo.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtgalonesdiesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtgalonesdiesel.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Txtefectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!Txtefectivo.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
