using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Radio_button_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RezervirajButton_Click(object sender, EventArgs e)
        {
            if (AvionRadio.Checked) { TextKutija.Text = "Odabrali ste prijevoz avionom"; }
            else if (AutobusRadio.Checked) { TextKutija.Text = "Odabrali ste prijevoz autobusom"; }
            else if (VlastitiPrijevozRadio.Checked) { TextKutija.Text = "Odabrali ste vlastiti prijevoz"; }
        }
    }
}
