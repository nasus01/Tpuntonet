using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.net
{
    public partial class Años_en_segundos : Form
    {
        Edadaños edadaños = new Edadaños();
        public Años_en_segundos()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            edadaños.setNumeronac(int.Parse(txtaño.Text));
            lbledad.Text = edadaños.calcular().ToString();
            lblsegundos.Text = edadaños.segundos().ToString();
            txtaño.Focus();
            txtaño.Text = "";


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }
    }
}
