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
    public partial class zamok : Form
    {
        public static class loca
        {
            public static int x { get; set; }
            public static int y { get; set; }
            public static int px { get; set; }
            public static int py { get; set; }
        }

        public zamok()
        {
            
            InitializeComponent();
            pictureBox1.Visible = false;
            label1.Visible = false;
            if (mainhero.sqget>0)
            {
                this.BackgroundImage = Properties.Resources.квествзят;
            }
            else if(mainhero.sqget==0)
            {
                this.BackgroundImage = Properties.Resources.квестневзятноподсказкадана;
            }
            else if (mainhero.sqget<0)
            {
                this.BackgroundImage = Properties.Resources.квестневзят;
            }
            if (медведь.medvedDialogWin > 5)
            {
                pictureBox1.Visible = true;
            }
            loca.x = pictureBox2.Location.X;
            loca.y = pictureBox2.Location.Y;
            if (secretquest.questhalfignore == true)
            {
                this.BackgroundImage = Properties.Resources.квестневзятноподсказкадана;
            }
        }

        

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

       

        private void W(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.x -= 5;
                    pictureBox2.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    textureoutx2();
                    textureouty2();
                    zdaniya1();
                    zdaniya2();
                    zdaniya3();
                    zdaniya4();
                    zdaniya5();
                    dvortip();
                    break;
                case Keys.S:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.y += 3;
                    pictureBox2.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    textureoutx2();
                    textureouty2();
                    zdaniya1();
                    zdaniya2();
                    zdaniya3();
                    zdaniya4();
                    zdaniya5();
                    dvortip();
                    break;
                case Keys.D:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.x += 5;
                    pictureBox2.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    textureoutx2();
                    textureouty2();
                    zdaniya1();
                    zdaniya2();
                    zdaniya3();
                    zdaniya4();
                    dvortip();
                    zdaniya5();
                    break;
                case Keys.W:
                    loca.px = loca.x;
                    loca.py = loca.y;
                    loca.y -= 3;
                    pictureBox2.Location = new Point(loca.x, loca.y);
                    textureoutx();
                    textureouty();
                    textureoutx2();
                    textureouty2();
                    zdaniya1();
                    zdaniya2();
                    zdaniya3();
                    zdaniya4();
                    zdaniya5();
                    dvortip();
                    break;
                case Keys.E:
                    secretquestget();
                    dvorets();
                    break;
                    
                default:
                    break;
            }
        }
       

        private void textureoutx()
        {
            if (pictureBox2.Location.X >= 1046)
            {
                loca.x = loca.px;
                pictureBox2.Location = new Point(loca.x,loca.y);
            }

        }

        

        private void textureouty()
        {
            if (pictureBox2.Location.Y >= 429)
            {
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }

        }

        private void textureoutx2()
        {
            if (pictureBox2.Location.X <= 0)
            {
                loca.x = loca.px;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void textureouty2()
        {
            if (pictureBox2.Location.Y <= 0)
            {
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }

        private void secretquestget()
        {
            if (mainhero.secretQuestFinish==0)
            {
                if (loca.x >= 232 && loca.x <= 341 && loca.y >= 336 && loca.y < 440)
                {
                    secretquest sq = new secretquest();
                    sq.Show();
                    this.Hide();
                }
            }else if (mainhero.secretQuestFinish<10)
            {
                if (loca.x >= 232 && loca.x <= 341 && loca.y >= 336 && loca.y < 440)
                {
                    questWaiting quest=new questWaiting();
                    quest.Show();
                    this.Hide();
                }
            }else if (mainhero.secretQuestFinish>20)
            {
                if (loca.x >= 232 && loca.x <= 341 && loca.y >= 336 && loca.y < 440)
                {
                    questFinish finish=new questFinish();
                    finish.Show();
                    this.Hide();
                }
            }
        }
        private void zdaniya1()
        {
            if (loca.x>=874&&loca.y<=83)
            {
                loca.x = loca.px;
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void zdaniya2()
        {
            if (loca.x >= 874 && loca.y>=115)
            {
                loca.x = loca.px;
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void zdaniya3()
        {
            if (loca.x<=412 && loca.y <= 177)
            {
                loca.x = loca.px;
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void zdaniya4()
        {
            if (loca.x>=337 &&loca.x <=404 && loca.y >= 212)
            {
                loca.x = loca.px;
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void zdaniya5()
        {
            if (loca.x <=232 && loca.y >=212)
            {
                loca.x = loca.px;
                loca.y = loca.py;
                pictureBox2.Location = new Point(loca.x, loca.y);
            }
        }
        private void dvorets()
        {
            if (loca.x<=100&&loca.y>=175&&loca.y<=280)
            {
                dvorets dvor = new dvorets();
                dvor.Show();
                this.Hide();
            }
        }
        private void dvortip()
        {
            if (loca.x <= 100 && loca.y >= 175 && loca.y <= 280)
            {
                label1.Visible = true;
            }
            else 
            {
                label1.Visible = false;                    
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
