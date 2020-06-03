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
    public partial class finalBattle : Form
    {
        private static Random chanceOfAction = new Random();
        private static int chanceInInteger;
        private static bool blockStatus;
        private static bool attackStatus;
        private static bool reflection;
        private static int bossHp;
        private static int bossDmg;
        private static int winOrLose;
        public finalBattle()
        {
            InitializeComponent();
            reflection = false;
            if (questFinish.mirrorExistance==100)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
            bossDmg = 45;
            bossHp = 150;
            button3.Visible = false;
            mainhero.hp = 200;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            labelsUpdate();
        }

        private void labelsUpdate()
        {
            label3.Text = $"Волшебник Конор:\nЗдоровье:{bossHp}\nАтака{bossDmg}";
            label2.Text = $"Код\nЗдоровье:{mainhero.hp}\nАтака:{mainhero.atk}";
            label2.Refresh();
            label3.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chanceInInteger=chanceOfAction.Next(0, 100);
            if (chanceInInteger<50)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Неудача";
                attackStatus = false;
                pictureBox1.Image = Properties.Resources.мечСломан;
            }else if (chanceInInteger>=50)
            {
                label1.ForeColor = Color.LimeGreen;
                label1.Text = "Удача";
                attackStatus = true;
                pictureBox1.Image = Properties.Resources.меч;
            }
            label1.Refresh();
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chanceInInteger = chanceOfAction.Next(0, 100);
            if (chanceInInteger < 50)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Неудача";
                blockStatus = false;
                pictureBox1.Image = Properties.Resources.мечбезблока;
            }
            else if (chanceInInteger >= 50)
            {
                label1.ForeColor = Color.LimeGreen;
                label1.Text = "Удача";
                blockStatus = true;
                pictureBox1.Image = Properties.Resources.мечсблоком;
            }
            label1.Refresh();
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reflection = true;
            blockStatus = true;
            label1.ForeColor = Color.MediumPurple;
            label1.Text = "Отражено";
            pictureBox1.Image = Properties.Resources.magicblock;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (attackStatus==true)
            {
                bossHp -= mainhero.atk;
                if (bossHp<=0)
                {
                    pictureBox1.Image = Properties.Resources.youwin;
                    winOrLose = 10;
                }
            }

            if (reflection==true)
            {
                bossHp -= bossDmg;
                blockStatus = true;
                
                if (bossHp <= 0)
                {
                    pictureBox1.Image = Properties.Resources.youwin;
                    winOrLose = 10;
                }
                
            }
            if (blockStatus==false)
            {
                chanceInInteger = chanceOfAction.Next(0, 100);
                if (chanceInInteger<50)
                {
                    label4.Text = "Промахнулся";
                    label4.ForeColor = Color.Red;
                }else if (chanceInInteger>=50)
                {
                    label4.Text = "Попал";
                    label4.ForeColor = Color.LimeGreen;
                    pictureBox1.Image = Properties.Resources.magic;
                    mainhero.hp -= bossDmg;
                    if (mainhero.hp<=0)
                    {
                        pictureBox1.Image = Properties.Resources.youdied;
                        winOrLose = -10;
                    }
                }
            }
            else
            {
                label4.Text = "Цель увернулась";
                label4.ForeColor = Color.SandyBrown;
            }
            

            if (mainhero.hp<=0||bossHp<=0)
            {
                button3.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
            }
            else
            {
                button3.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
                if (questFinish.mirrorExistance == 100)
                {
                    button4.Visible = true;
                }
                else
                {
                    button4.Visible = false;
                }
            }
            labelsUpdate();
            label1.Text = " ";
            attackStatus = false;
            blockStatus = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void датьЗеркалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questFinish.mirrorExistance = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (winOrLose==10)
            {
                epilogue epiloguePicture=new epilogue();
                epiloguePicture.Show();
                this.Hide();
            }else if (winOrLose==-10)
            {
                tryAgain gameOver=new tryAgain();
                gameOver.Show();
                this.Hide();
            }
        }
    }
}
