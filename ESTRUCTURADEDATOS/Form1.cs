using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTRUCTURADEDATOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (CEDULADEIDENTIDAD.Text == "C/I")
            {
                CEDULADEIDENTIDAD.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (CEDULADEIDENTIDAD.Text == "")
            {
                CEDULADEIDENTIDAD.Text = "C/I";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
