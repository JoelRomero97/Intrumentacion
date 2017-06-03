using MaterialSkin.Controls;
using PicWinUSB.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intrumentacion
{
    public partial class Instru : MaterialForm
    {
        lectura_de_datos datos;
        operaciones operaciones;
        public Instru()
        {
            datos = new lectura_de_datos();
            operaciones = new operaciones();
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instru_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtSum1.Text);
            datos.numero_2 = Double.Parse(txtSum2.Text);
            txtSumRes.Text = operaciones.suma(datos.numero_1, datos.numero_2).ToString();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtSum1.Text);
            datos.numero_2 = Double.Parse(txtSum2.Text);
            txtResRes.Text = operaciones.resta(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtSum1.Text);
            datos.numero_2 = Double.Parse(txtSum2.Text);
            txtMultiRes.Text = operaciones.multi(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtSum1.Text);
            datos.numero_2 = Double.Parse(txtSum2.Text);
            txtDivRes.Text = operaciones.div(datos.numero_1, datos.numero_2).ToString();
        }
    }
}
