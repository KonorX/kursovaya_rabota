using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    
    static class mainhero
    {
        public static int atk { get; set; }
        public static int hp { get; set; }
        public static int sqget { get; set; }
        public static int namesq { get; set; }
        public static int FirMeet { get; set; }
        public static int secretQuestFinish { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainhero.FirMeet = 0;
            mainhero.atk = 30;
            Application.Run(new Form1());
        }
    }
}
