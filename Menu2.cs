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
    public partial class Menu2 : Form
    {

        
        


        public Menu2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Diesel fmrs2 = new Diesel();
            fmrs2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Regular fmrs3 = new Regular();
              fmrs3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Especial fmrs4 = new Especial();
            fmrs4.Show();
            this.Hide();
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu1 fmrs4 = new Menu1();
            fmrs4.Show();
            this.Hide();
        }

        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
