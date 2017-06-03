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
        public Instru()
        {
            InitializeComponent();
            var Material = MaterialSkinManager.Instance;
            Material.AddFormToManage(this);
            Material.Theme = MaterialSkinManager.Themes.DARK;
            Material.ColorScheme = new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }
    }
}
