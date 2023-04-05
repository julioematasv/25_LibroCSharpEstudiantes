using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEjercicio2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text ="Si";
            label2.Text = "Si";
            label3.Text = "Si";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "No";
            label2.Text = "No";
            label3.Text = "No";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "A";
            label2.Text = "B";
            label3.Text = "C";
        }
    }
}
