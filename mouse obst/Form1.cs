using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouse_obst
{
    public partial class Form1 : Form
    {
        Point p = new Point();
        Form2 f2 = new Form2();
        int OK = new int();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (OK == 1)
                MessageBox.Show("Ai iesit de pe traseu, desteptaciune!", "Ce faci, ma?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                OK = 1;         
            p.X = label1.Location.X + label1.Width / 2;
            p.Y = label1.Location.Y + label1.Height / 2;
            Cursor.Position = PointToScreen(p);
            Cursor.Clip=this.Bounds;           
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai reusit! Mult ti-a mai luat...", "Ai terminat nivelul 1. Pfff...amator.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }
    }
}
