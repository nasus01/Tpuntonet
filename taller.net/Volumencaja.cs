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
    public partial class Volumencaja : Form
    {
        Volumen Volumen = new Volumen();
        public Volumencaja()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Volumen.setnumeroalto(double.Parse(txtalto.Text));
            Volumen.setnumeroancho(double.Parse(txtancho.Text));
            Volumen.setnumerolargo(double.Parse(txtlargo.Text));
            lbltotal.Text = Volumen.calcular().ToString();
            lbltotal.Visible = true;
            txtalto.Focus();
            txtalto.Text = "";
            txtancho.Text = "";
            txtlargo.Text = "";



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }
    }
}
