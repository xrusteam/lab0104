using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab0104
{
    
    static class Program
    {
        public static int userPoints = 10;
       public static string username = " ";
        public static bool isGamePlayed = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            if (isGamePlayed)
            {
                using (StreamWriter text = new StreamWriter("users.txt", true))
                {
                    text.WriteLine(username + " набрал " + userPoints.ToString());
                }
            }
        }
    }
}
