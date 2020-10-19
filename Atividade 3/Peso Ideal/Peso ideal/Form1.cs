using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_ideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, result;


            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                result = (valor1 * 72.7) - 58;
                result = Math.Round(result, MidpointRounding.AwayFromZero);

                if (valor2 > result)
                    MessageBox.Show("Regime obrigatório já!");
                if (valor2 == result)
                    MessageBox.Show("Voce está com o peso ideal!"); 
                if (valor2 < result)
                    MessageBox.Show("Coma bastante massas e doces");
            }

            else
            {
                result = (valor1 * 62.1) - 44.7;
                result = Math.Round(result, MidpointRounding.AwayFromZero);

                if (valor2 > result)
                    MessageBox.Show("Regime obrigatório já!");
                if (valor2 == result)
                    MessageBox.Show("Voce está com o peso ideal!");
                if (valor2 < result)
                    MessageBox.Show("Coma bastante massas e doces");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
