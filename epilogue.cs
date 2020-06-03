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
    public partial class epilogue : Form
    {
        private static int endOfEpilogue;
        public epilogue()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.волшебникрасстроен;
            endOfEpilogue = 0;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (endOfEpilogue == 0)
            {
                button1.Text = "далее";
                if (FrogDialog.gettingFrogPrincess>0)
                {
                    label1.Text =
                        "Код принес шляпу побежденного волшебника чем доказал, что именно он достоин награды которую так хотел, король передал ему её очень нехотя\nПосле это Код вместе с принцессой сбежали из королевства, ведь они были влюблены друг в друга,да и принцессе не нравилось, что всё за неё решал отец\nСын волшебника женился на той самой подруге принцессы с которой у них была схватка,в процессе битвы они поняли что их характеры близки да и вообще они скорее играли какую-то романтическую сценку чем сражались";
                    pictureBox1.Image = Properties.Resources.звезданезлая;
                }
                else if(FrogDialog.gettingFrogPrincess<=0)
                {
                    label1.Text =
                        "Код принес шляпу побежденного волшебника чем доказал, что именно он достоин награды которую так хотел, король передал ему её очень нехотя\nПосле это Код уже будучи сильным героем спас свою деревню\nСын волшебника женился на той самой подруге принцессы с которой у них была схватка,в процессе битвы они поняли что их характеры близки да и вообще они скорее играли какую-то романтическую сценку чем сражались";

                    pictureBox1.Image = Properties.Resources.звездазлая;
                }
                else
                {
                    label1.Text = $"{FrogDialog.gettingFrogPrincess}";
                }
                endOfEpilogue = 1;
            }else if (endOfEpilogue==1)
            {
                титры end=new титры();
                end.Show();
                this.Hide();
            }
        }
    }
}
