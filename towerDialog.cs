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
    public partial class towerDialog : Form
    {
        private static int dialogProgress;
        public towerDialog()
        {
            InitializeComponent();
            label4.Visible = false;
            if (FrogDialog.gettingFrogPrincess==100)
            {
                label2.Text = "Так это может ты заколдовал принцессу в ту лягушку,надо мне с тобой разобраться, надеюсь ты и без боя снимешь с неё проклятие";
            }
            else
            {
                label2.Text = "О,наконец-то, осталось мне тогда прихлопнуть тебя или ты расколдуешь её просто так,хотя скорее всего не расколдуешь ты";
            }

            dialogProgress = 0;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (dialogProgress==0)
            {
                pictureBox1.Image = Properties.Resources.heroFace;
                pictureBox2.Image = Properties.Resources.wizardFace;
                label1.Text = "Хех,как будто бы я буду сражаться с тобой, для этого у меня есть сын\n-Сына,тут очередной, разберись с ним";
                label4.Visible = true;
                label4.Text = "Хорошо,отец";
                pictureBox3.Image = Properties.Resources.wizardson;
                dialogProgress++;
                label2.Text = "Ну,как хочешь, сразу справлюсь с ним,потом с отцом";
            }else if (dialogProgress==1)
            {
                label4.Text = "Эй,я вообще то тоже пришла спасать свою подругу!\n Незнакомец, иди сражайся с волшебником, а я займусь его сыном";
                pictureBox3.Image = Properties.Resources.princessfriend;
                label2.Text = "Внезапно,конечно, но ладно";
                pictureBox2.Image = Properties.Resources.волшебникзлой;
                label1.Text = "Мелочь!\nРаздражаете!";
                dialogProgress++;
            }else if (dialogProgress==2)
            {
                finalBattle final=new finalBattle();
                final.Show();
                this.Hide();
            }
           
        }
    }
}
