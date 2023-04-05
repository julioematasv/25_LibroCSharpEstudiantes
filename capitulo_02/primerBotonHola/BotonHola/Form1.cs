using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonHola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola Julio Mata, hiciste clic en el botón!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Número de Teléfono: 603 10 62 78";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo!!");
        }
    }
}
