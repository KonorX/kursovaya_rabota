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
    public partial class secretquest : Form
    {
        public static bool questhalfignore { get; set; }

        int i = 1;
        int u = 1;

        public secretquest()
        {
            InitializeComponent();
            Image mh=new Bitmap(@"C:\Users\User\Desktop\kursach\faces\mainheroface1.png");
            Image qu=new Bitmap(@"C:\Users\User\Desktop\kursach\faces\лицоsq1.png");
            pictureBox2.Image = mh;
            pictureBox1.Image = qu;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            
            mainhero.namesq = 100;
            timerhero.Enabled = true;
            if (i >= 10)
            {
                timerhero.Enabled = false;
                timerqu.Enabled = true;
                if (u >= 10)
                {
                    timerqu.Enabled = false;
                }
            }

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

            zamok zam = new zamok();
            zam.Show();
            this.Hide(); 
            mainhero.sqget = 0;
            questhalfignore = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7 opis = new Form7();
            opis.Show();
            this.Hide();
            mainhero.namesq = 100;
            mainhero.sqget = 100;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            timerhero.Enabled = true;
            if (i>=10)
            {
                timerqu.Enabled = true;
                timerhero.Enabled = false;
                
                if (u>=10)
                {
                    timerqu.Enabled = false;
                }
            }
            label9.Visible = true;


            mainhero.sqget = -100;
            mainhero.namesq = -100;
        }

        

        private void timerhero_Tick(object sender, EventArgs e)
        {
            Image facemain1 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\mainheroface1.png");
            Image facemain2 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\mainheroface2.png");
            Image facemain3 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\mainheroface3.png");
            switch (i)
            {
                case 7:
                case 4:
                case 1:
                    pictureBox2.Image = facemain1;
                    break;
                case 8:
                case 5:
                case 2:
                    pictureBox2.Image = facemain2;
                    break;
                case 9:
                case 6:
                case 3:
                    pictureBox2.Image = facemain3;
                    break;
                default:
                    pictureBox2.Image = facemain1;
                    
                    break;
            }
            i++;
        }

        private void timerqu_Tick(object sender, EventArgs e)
        {
            Image faceq1 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\лицоsq1.png");
            Image faceq2 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\лицоsq2.png");
            Image faceq3 = new Bitmap(@"C:\Users\User\Desktop\kursach\faces\лицоsq3.png");
            switch (u)
            {
                case 7:
                case 4:
                case 1:
                    pictureBox1.Image = faceq1;
                    break;
                case 8:
                case 5:
                case 2:
                    pictureBox1.Image = faceq2;
                    break;
                case 9:
                case 6:
                case 3:
                    pictureBox1.Image = faceq3;
                    break;
                default:
                    pictureBox1.Image = faceq1;
                    
                    break;
            }
            u++;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            zamok zam = new zamok();
            zam.Show();
            this.Hide();
            mainhero.sqget = -10000;

        }
    }
}
