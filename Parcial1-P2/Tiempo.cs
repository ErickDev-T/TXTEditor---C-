using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_P2
{
    public partial class Tiempo : Form
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horalabel.Text = DateTime.Now.ToLongTimeString();
        
        }
    }
}
