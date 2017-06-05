using MaterialSkin;
using MaterialSkin.Controls;
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
        lectura_de_datos  datos;
        operaciones op;
        public Instru()
        {
            InitializeComponent();
            var Material = MaterialSkinManager.Instance;
            Material.AddFormToManage(this);
            Material.Theme = MaterialSkinManager.Themes.DARK;
            Material.ColorScheme = new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            datos = new lectura_de_datos();
            op = new operaciones();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtSum1.Text);
            datos.numero_2 = Double.Parse(txtSum2.Text);
            txtSumRes.Text = op.suma(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtRes1.Text);
            datos.numero_2 = Double.Parse(txtRes2.Text);
            txtRes.Text = op.resta(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtMulti1.Text);
            datos.numero_2 = Double.Parse(txtMulti2.Text);
            txtMultiRes.Text = op.multi(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            datos.numero_1 = Double.Parse(txtDiv1.Text);
            datos.numero_2 = Double.Parse(txtDiv2.Text);

            if (datos.numero_2 == 0)
            {
                MessageBox.Show("Requieres cambiar el denominador, debe ser distinto de 0");
                txtDiv2.Clear();
                datos.numero_2 = Double.Parse(txtDiv2.Text);
            }

            txtDivRes.Text = op.div(datos.numero_1, datos.numero_2).ToString();
        }

        private void btnLEDToggle_Click(object sender, EventArgs e)
        {
            op.leds_toggle();
        }

        private void btnLEDVerdeOn_Click(object sender, EventArgs e)
        {
            op.led_verde_on();
        }

        private void btnLEDRojoOn_Click(object sender, EventArgs e)
        {
            op.led_rojo_on();
        }

        private void btnLEDon_Click(object sender, EventArgs e)
        {
            op.leds_on();
        }

        private void btnLEDof_Click(object sender, EventArgs e)
        {
            op.leds_off();
        }
    }
}
