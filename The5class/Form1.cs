using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The5class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        Color getRandomColor()
        {
            return Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            int x0 = this.Width / 2;
            int y0 = this.Height / 2;
            for (int i = 0; i < this.Height/2; i++)
            {
                g.DrawEllipse(
                    new Pen(getRandomColor(), 1),
                    x0 - i , y0 - i, i * 2, i * 2
                    );
                g.DrawRectangle(
                    new Pen(getRandomColor(), 1),
                     x0 - i, y0 - i, i * 2, i * 2
                    );

            }
            g.Dispose();
        }
    }
}
