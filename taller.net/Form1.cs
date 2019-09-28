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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Idicemasa idicemasa = new Idicemasa();
            idicemasa.Show();
            this.Hide();
        }

        private void btnpromedionotas_Click(object sender, EventArgs e)
        {
            Notaspromedio notaspromedio = new Notaspromedio();
            notaspromedio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raizcuadrada raizcuadrada = new Raizcuadrada();
            raizcuadrada.Show();
            this.Hide();
        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {
            Volumencaja volumencaja = new Volumencaja();
            volumencaja.Show();
            this.Hide();
        }

        private void btnedadaños_Click(object sender, EventArgs e)
        {
            Años_en_segundos años_En_Segundos = new Años_en_segundos();
            años_En_Segundos.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Etapasvida etapasvida = new Etapasvida();
            etapasvida.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Show();
            this.Hide();
        }
    }
}
