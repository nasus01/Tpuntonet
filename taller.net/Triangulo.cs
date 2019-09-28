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
    public partial class Triangulo : Form
    {
        Areatriangulo Areatriangulo = new Areatriangulo();
        public Triangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Areatriangulo.setaltura(int.Parse(txtaltura.Text));
            Areatriangulo.setBase(int.Parse(txtbase.Text));
           
            lblarea.Text = Areatriangulo.calcular().ToString();
            lblarea.Visible = true;
            txtbase.Focus();
            txtbase.Text = "";
            txtaltura.Text = "";
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }
    }
}
