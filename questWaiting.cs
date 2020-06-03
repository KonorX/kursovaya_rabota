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
    public partial class questWaiting : Form
    {
        public questWaiting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zamok castle=new zamok();
            castle.Show();
            this.Hide();
        }
    }
}
