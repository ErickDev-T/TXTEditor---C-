using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace Parcial1_P2
{
    
    public partial class PaintForm1 : Form
    {
        private Graphics g;
        private int x = -1;
        private int y = -1;
        private bool moving = false;
        private Pen pen;

        public PaintForm1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }

        private void PaintForm1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            

        }

        private void PaintForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                this.Cursor = Cursors.Cross;

            }
        }

        private void PaintForm1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            this.Cursor = Cursors.Default;
        }
    }
}
