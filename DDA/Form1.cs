using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);

            int x2 = Convert.ToInt32(textBox4.Text);
            int y2 = Convert.ToInt32(textBox3.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            if (x1 >= 0 & y1 >= 0 & x2 >= 0 & y2>=0)
            {
                ddaline(p1, p2);

            }
            else
            {
                string message = "please enter positive numbers";
                string title = "Error";
                MessageBox.Show(message, title);
            }

           
        }

        private void ddaline(Point p1, Point p2)
        {
            int k = 0;
            double xinc, yinc, x, x1, y, y1, steps;
            Bitmap p = new Bitmap(this.Width, this.Height);
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            if (deltaX > deltaY) steps = deltaX;
            else steps = deltaY;
            xinc = deltaX / steps;
            yinc = deltaY / steps;
            x = x1 = p1.X;
            y = y1 = p1.Y;
            //casting
            p.SetPixel((int)x, (int)y, Color.White);

            //k=1 ........steps;

            for (k = 1; k <= steps; k++)
            {
                x = x + xinc;
                x = Math.Round(x, 0);
                y = y + yinc;
                y = Math.Round(y, 0);
                p.SetPixel((int)x, (int)y, Color.White);
            }
            pictureBox1.Image = p;



        }
        private void intVal(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            intVal(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            intVal(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            intVal(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            intVal(e);
        }
    }
}
