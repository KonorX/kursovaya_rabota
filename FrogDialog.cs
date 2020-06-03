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
    public partial class FrogDialog : Form
    {
        public static int gettingFrogPrincess { get; set; }
        private static int dialogProgress;
        public FrogDialog()
        {
            InitializeComponent();
            dialogProgress = 0;
            pictureBox2.Visible = false;
            gettingFrogPrincess = 0;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (dialogProgress == 0)
            {
                label2.Visible = false;
                label3.Text = "*лягушка дрожит и усиленно смотрит на мою флягу с водой*\n-Хм, видимо надо дать этой лягушке попить и положить её в тепло,например в мою сумку";
                label1.Text = "Напоить и положить в сумку";
                dialogProgress++;
            }else if (dialogProgress==1)
            {
                label3.Text = "Лягушка смотрит в сторону башни неподалеку, она выглядит страшновато, видимо мне туда надо пойти, может победив того кто заколдовал человека в эту лягушку я сниму проклятие";
                label1.Text = "пойти в замок";
                pictureBox1.Image = Properties.Resources.froggif;
                pictureBox2.Image = Properties.Resources.tower;
                pictureBox2.Visible = true;
                dialogProgress++;
            }else if (dialogProgress==2)
            {
                gettingFrogPrincess = 100;
                towerDialog dialogWithPrincess=new towerDialog();
                dialogWithPrincess.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (dialogProgress==0)
            {
                label1.Visible = false;
                pictureBox1.Visible = false;
                label3.Text = "Код видит поблизости страшноватую башню, может хоть там есть эта принцесса,надо сходить туда";
                label2.Text = "пойти в замок";
                pictureBox2.Image = Properties.Resources.tower;
                pictureBox2.Visible = true;
                dialogProgress--;
            }
            else if(dialogProgress==-1)
            {
                towerDialog dialog=new towerDialog();
                dialog.Show();
                this.Hide();
            }
        }
    }
}
