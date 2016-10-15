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
    public partial class Form3 : Form
    {
        Point p1 = new Point();
        Point p = new Point();
        int n1 = new int();
        int OK = new int();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1.Y == 32)
            { n1 = 1; p1.Y = p1.Y + 4; }
            if (p1.Y == 260)
            { n1 = 2; p1.Y = p1.Y - 4; }
            if (p1.Y > 32 && p1.Y < 260)
                if (n1 == 1)
                    p1.Y = p1.Y + 4;
                else
                    p1.Y = p1.Y - 4;
            label5.Top = p1.Y;
                      
            
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            if (OK == 1)
                MessageBox.Show("Ai iesit de pe traseu, desteptaciune!", "Ce faci, ma?", MessageBoxButtons.OK, MessageBoxIcon.Stop);               
            else
                OK=1;
            p.X = label1.Location.X + label1.Width / 2;
            p.Y = label1.Location.Y + label1.Height / 2;
            p1.X = 90;
            p1.Y = 32;
            Cursor.Position = PointToScreen(p);
            Cursor.Clip = this.Bounds;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai reusit! Mult ti-a mai luat...", "Ai terminat nivelul 3...Insfarsit!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
