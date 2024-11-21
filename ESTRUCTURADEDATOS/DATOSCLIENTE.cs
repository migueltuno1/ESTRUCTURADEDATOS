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
        private int num;
        public DATOSCLIENTE(Form1.Dci inf)
        {
            InitializeComponent();
            label1.Text = inf.cedula;

        }

        private void JHON_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Green;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Black;
            this.num = 1;
        }

        private void RODRIGO_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Green;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Black;
            this.num = 2;
        }


        private void DIEGO_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Green;
            JOSE.ForeColor = Color.Black;
            this.num = 3;
        }

        private void JOSE_CheckedChanged(object sender, EventArgs e)
        {
            JHON.ForeColor = Color.Black;
            RODRIGO.ForeColor = Color.Black;
            DIEGO.ForeColor = Color.Black;
            JOSE.ForeColor = Color.Green;
            this.num = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (this.num)
            {
                case 1:
                    if (this.num == 1)
                    {
                        EXTRACTOS form1 = new EXTRACTOS();
                        form1.Show();
                        Hide();
                    }
                    break;
                case 2:
                    if (this.num == 2)
                    {
                        EXTRACTOS form1 = new EXTRACTOS();
                        form1.Show();
                        Hide();
                    }
                    break ;
                case 3:
                    if (this.num == 3)
                    {
                        EXTRACTOS form1 = new EXTRACTOS();
                        form1.Show();
                        Hide();
                    }
                    break;
                case 4:
                    if (this.num == 4)
                    {
                        EXTRACTOS form1 = new EXTRACTOS();
                        form1.Show();
                        Hide();
                    }
                    break;

            }
        }

        }
    }

