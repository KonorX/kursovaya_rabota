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
    public partial class медведь : Form
    {
        
        public static int medvedDialogWin { get; set; }
        private static int dialogProgress=0;
        public медведь()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.медведьлицо;
            pictureBox2.Image = Properties.Resources.mainheroface3;
            label1.Text = "Эй,что тебе надо?";
            label2.Text = "твоя голова и ананас";
            label3.Text = "давай кое о чем договоримся";
            label4.Visible = false;
            button1.Visible = false;
            medvedDialogWin = 0;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            medvedDialogWin = 0;
            битвасмедведем б = new битвасмедведем();
            б.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (dialogProgress==0)
            {
                label2.Visible = false;
                label4.Visible = true;
                label1.Location = new Point(249, 306);
                label1.Text = "Эх,у тебя то хоть друзья есть,я бы вот тоже хотел найти друзей, мнооого друзей";
                label3.Text = "Знаешь,у меня есть одна идея";
                label3.Refresh();
                label1.Refresh();
                dialogProgress++;
            }else if (dialogProgress==1)
            {
                button1.Visible = true;
                label4.Text = "Ты можешь стать городским музыкантом,главное покажи жителям что ты не хочешь их сьесть или замаскируйся";
                label3.Visible = false;
                label1.Text = "А идея хороша, я стану исполнять на скрипке,флейте и трубе";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medvedDialogWin = 10;
            mainhero.secretQuestFinish = 100;
            Form6 getBack=new Form6();
            getBack.Show();
            this.Hide();
        }
    }
}
