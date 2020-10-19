using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_do_cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Raio, Altura, Volume;


            Raio = Convert.ToDouble(textBox1.Text);
            Altura = Convert.ToDouble(textBox2.Text);

            Volume = Math.PI * Raio * Raio * Altura;


            label5.Text = Convert.ToString(Volume);
        }
    }
}
