using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day18_03
{
    public partial class Form1 : Form
    {
        List<Point> ListP = new List<Point>(); // linked list

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(ListP.Count == 3)
            {
                e.Graphics.DrawLine(Pens.Red, ListP[0], ListP[1]);
                e.Graphics.DrawLine(Pens.Green, ListP[1], ListP[2]);
                e.Graphics.DrawLine(Pens.Blue, ListP[0], ListP[2]);
                ListP.Clear();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X,e.Y);           
            ListP.Add(pt);
            Invalidate();
        }
    }
}
