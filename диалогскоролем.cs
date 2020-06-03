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
    public partial class диалогскоролем : Form
    {
        public static int Mcf { get; set; }
        public static int Kf { get; set; }
        public диалогскоролем()
        {
            InitializeComponent();
            Mcf = 0;
            Kf = 0;
            this.BackgroundImage = Properties.Resources.temfon;
            pictureBox1.Image = Properties.Resources.лицокороля1;
            pictureBox2.Image = Properties.Resources.mainheroface1;
            label3.Visible = false;
            if (mainhero.namesq==100)
            {
                label1.Text = "Так,Код, что тебе нужно от меня?";
                label1.Refresh();
            }
            else
            {
                label1.Text = "Эй,незнакомец,что тебе нужно от меня?";
                label1.Refresh();
            }
            label2.Text = "Я слышал что ты владеешь Клавой Бессмертия, я найду и верну твою дочь\n внаграду же дай дай мне этот всемогущий артефакт";
            label2.Refresh();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Если найдешь Звезду,то я отлам тебе эту Клаву\n но чтобы лишний волосок с неё не слетел\n а то без головы останешься";
            label1.Refresh();
            label2.Visible = false;
            label3.Visible = true;
            label3.Text = "Пойду с радостью выполнять задание Ваша честь\n\tкликни чтобы завершить диалог";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainhero.FirMeet = 100;
            dvorets d = new dvorets();
            d.Show();
            this.Hide();

        }
    }
}
