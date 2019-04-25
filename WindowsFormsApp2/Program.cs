using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static string username;
        public static string password;
        public static int[] final;
        public static int apple = 90000;
        public static int samsung = 80000;
        public static int huawei = 30000;
        public static int vivo = 50000;
        public static int sony = 45000;
        public static int motorolla = 25000;
        public static int oneplus = 60000;

        public static int total = 0;
        public static int qtyapple = 0;
        public static int qtysamsung = 0;
        public static int qtyhuawei = 0;
        public static int qtyvivo = 0;
        public static int qtysony = 0;
        public static int qtymotorolla = 0;
        public static int qtyoneplus = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
