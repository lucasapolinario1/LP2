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

        private void button1_Click(object sender, EventArgs e)
        {
            int v1, v2, v3, count;
            count = 1;
            v1 = Convert.ToInt16(textBox3.Text);
            v2 = Convert.ToInt16(textBox2.Text);
            v3 = Convert.ToInt16(textBox1.Text);

            if (v1 == v2)
            {
                count = count + 1;

            }

            if (v1 == v3)
            {
                count = count + 1;

            }

            if (v2 == v3)
            {

                count = count + 1;
            }

            if (count == 2)
            {
                MessageBox.Show("O triangulo é isóceles");

            }

            if (count > 3)
            {
                MessageBox.Show("O triangulo é equilátero");
            }
            else if(count ==1) 
            {
                MessageBox.Show("O triangulo é escaleno");
            }
        }
    }
}
