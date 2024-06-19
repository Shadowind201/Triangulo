using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (a == b && b == c)
            {
                resultado.Text = "Triangulo Equilatero";
                this.equilatero.Visible = true;
                this.escaleno.Visible = false;
                this.isoceles.Visible = false;
            }
            else if (a != b && b != c)
            {
                resultado.Text = "Triangulo Escaleno";
                this.escaleno.Visible = true;
                this.equilatero.Visible = false;
                this.isoceles.Visible = false;
            }
            else if (a == b || a ==c || b == c)
            {
                resultado.Text = "Triangulo Isoceles";
                this.isoceles.Visible= true;
                this.escaleno.Visible = false;
                this.equilatero.Visible = false;
            }
        }
    }
}
