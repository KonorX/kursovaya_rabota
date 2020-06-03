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
    public partial class битвасмедведем : Form
    {
        private static Random chanceOfAction=new Random();
        private static int chanceInInteger;
        private static bool blockStatus;
        private static bool attackStatus;
        private static int bearHp;
        private static int bearDamage;
        private static int winOrLose;
        public битвасмедведем()
        {
            InitializeComponent();
            bearHp = 120;
            bearDamage = 20;
            button3.Visible = false;
            winOrLose = 0;
            mainhero.hp = 100;
            labelsUpdate();
        }

        private void labelsUpdate()
        {
            label1.Text = $"Код\nЗдоровье:{mainhero.hp}\nАтака:{mainhero.atk}";
            label2.Text = $"Медведь\nЗдоровье:{bearHp}\nАтака:{bearDamage}";
            label1.Refresh();
            label2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            chanceInInteger= chanceOfAction.Next(0, 100);
            if (chanceInInteger<50)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Неудача";
                pictureBox1.Image = Properties.Resources.мечСломан;
                attackStatus = false;
            }
            else if(chanceInInteger >= 50)
            {
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "Удача";
                attackStatus = true;
                
            }
            label3.Refresh();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chanceInInteger = chanceOfAction.Next(0, 100);
            if (chanceInInteger<50)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Неудача";
                pictureBox1.Image = Properties.Resources.мечбезблока;
                blockStatus = false;
            }
            else if(chanceInInteger>=50)
            {
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "Удача";
                blockStatus = true;
                pictureBox1.Image = Properties.Resources.мечсблоком;
            }
            label3.Refresh();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (attackStatus == true)
            {
                bearHp -= mainhero.atk;
                if (bearHp <= 0)
                {
                    pictureBox1.Image = Properties.Resources.youwin;
                    winOrLose = 10;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.меч;
                }
            }

            if (blockStatus == false)
            {
                chanceInInteger = chanceOfAction.Next(0, 100);
                if (chanceInInteger<50)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Промахнулся";
                }
                else if(chanceInInteger>=50)
                {
                    label4.ForeColor = Color.LimeGreen;
                    label4.Text = "Попал";
                    mainhero.hp -= bearDamage;
                    if (mainhero.hp<=0)
                    {
                        pictureBox1.Image = Properties.Resources.youdied;
                        winOrLose = -10;
                    }
                }
            }
            else
            {
                label4.ForeColor = Color.SandyBrown;
                label4.Text = "Парирование";
            }

            if (mainhero.hp<=0||bearHp<=0)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
            }
            labelsUpdate();
            label3.Text = " ";
            attackStatus = false;
            blockStatus = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (winOrLose>1)
            {
                bearBattleEpilogue epilogue=new bearBattleEpilogue();
                epilogue.Show();
                this.Hide();
            }
            else if (winOrLose<-1)
            {
                bearBattleTryAgain tryAgain=new bearBattleTryAgain();
                tryAgain.Show();
                this.Hide();
            }
            
        }
    }
}
