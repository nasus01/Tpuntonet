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
    public partial class Etapasvida : Form
    {
        Etapas Etapas = new Etapas();
        public Etapasvida()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Etapas.setNumeroedad(int.Parse(txtedad.Text));
            txtedad.Focus();
            txtedad.Text = "";
            if (Etapas.getNumeroedad() <= 10)
            {
                MessageBox.Show("es un niño");
            }
            else
            {
                if (Etapas.getNumeroedad() <= 14)
                {
                    MessageBox.Show("es un pre-adolecente");
                }
                else
                {
                    if (Etapas.getNumeroedad() <= 18)
                    {
                        MessageBox.Show("es un adolecente");
                    }
                    else
                    {
                        if (Etapas.getNumeroedad() <= 25)
                        {
                            MessageBox.Show("es un joven");
                        }
                        else
                        {
                            if (Etapas.getNumeroedad() <= 65)
                            {
                                MessageBox.Show("es un adulto");
                            }
                            else
                            {
                                if (Etapas.getNumeroedad() >65)
                                {
                                    MessageBox.Show("es un anciano");
                                }
                            }
                        }

                    }
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }
    }
}
