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
    public partial class bearBattleEpilogue : Form
    {
        public bearBattleEpilogue()
        {
            InitializeComponent();
            mainhero.secretQuestFinish = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 afterEpilogue=new Form6();
            afterEpilogue.Show();
            this.Hide();
        }
    }
}
