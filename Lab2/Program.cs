using System;
using System.Windows.Forms;

namespace Lab2_AllTasks
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormWinQuestion());
        }
    }
}
