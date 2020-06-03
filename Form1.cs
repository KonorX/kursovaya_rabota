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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainhero.sqget = -100;
            mainhero.namesq = 0;
            mainhero.secretQuestFinish = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void первыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void второйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            битвасмедведем fightWithBear=new битвасмедведем();
            fightWithBear.Show();
            this.Hide();
        }

        private void диалогСЛягухойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrogDialog dialog=new FrogDialog();
            dialog.Show();
            this.Hide();
        }

        private void третийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalBattle final=new finalBattle();
            final.Show();
            this.Hide();
        }
    }
}
