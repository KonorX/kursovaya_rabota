using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class dvorets : Form
    {
        private static class loca
        {
            public static int x { get; set; }
            public static int y { get; set; }
            public static int px { get; set; }
            public static int py { get; set; }
        }
        public dvorets()
        {
            InitializeComponent();
            loca.x = pictureBox1.Location.X;
            loca.y = pictureBox1.Location.Y;
            this.BackgroundImage = Properties.Resources.дворец;
            pictureBox1.Image = Properties.Resources.gokust;
            pictureBox2.Visible = false;
        }

        private void W(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.y -= 3;
                    pictureBox1.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    break;
                case Keys.A:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.x -= 5;
                    pictureBox1.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    break;
                case Keys.S:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.y += 3;
                    pictureBox1.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    break;
                case Keys.D:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.x += 5;
                    pictureBox1.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    break;
                case Keys.E:
                    king();
                    break;
                default:
                    break;
            }
        }

        private void textureoutx()
        {
            if (loca.x>=723||loca.x<=494)
            {
                loca.x = loca.px;
                pictureBox1.Location = new Point(loca.x, loca.y);
            }
        }
        private void textureouty()
        {
            if (loca.y <= 140 || loca.y >= 358)
            {
                loca.y = loca.py;
                pictureBox1.Location = new Point(loca.x, loca.y);
            }
        }
        private void king()
        {
            if (loca.x<=550)
            {
                pictureBox2.Image = Properties.Resources.знакготовности;
                pictureBox2.Visible = true;
                диалогскоролем d = new диалогскоролем();
                d.Show();
                this.Hide();
            }
        }

        

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходИзДворцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zamok z = new zamok();
            z.Show();
            this.Hide();
        }
    }
}
