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
    public partial class DATOSCLIENTE : Form
    {
        public DATOSCLIENTE(Form1.Dci inf)
        {
            InitializeComponent();
        }

        private void JHON_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Green;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Black;
        }

        private void RODRIGO_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Green;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Black;
        }
    

        private void DIEGO_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Green;
            JOSE.ForeColor = Color.Black;
        }

        private void JOSE_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
