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
    public partial class Especial : Form
    {
        public Especial()
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

        private void Especial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIrGalonesEfectivo_Click(object sender, EventArgs e)
        {
            panelpagarefectivo.Show();
        }

        private void btnIrGalonesDiesel_Click(object sender, EventArgs e)
        {
            panelpagargalones.Show();
            
            double galones;
            double dinero;
            double galon = 4.45;
            galones = Convert.ToDouble(txtgalonesespecial.Text);
            dinero = galon * galones;


            txtdinerogalonesespecial.Text = dinero.ToString();
        }

        private void btnIrGalonesEfectivo_Click_1(object sender, EventArgs e)
        {
            panelpagarefectivo.Show();
            double galones;
            double dinero;
            double galon = 4.45;
            dinero = Convert.ToDouble(Txtefectivo.Text);
            galones = dinero / galon;

            txtgalonesrecibidosdiesel.Text = Math.Round(galones, 2).ToString();




            double efectivo;


            efectivo = Convert.ToDouble(Txtefectivo.Text);

            txtdinero.Text = efectivo.ToString();
        }

        private void Especial_Load(object sender, EventArgs e)
        {

        }

        private void txtgalonesespecial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgalonesespecial_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtgalonesespecial.Text.Contains(".")))
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
