using System;
using System.Windows.Forms;

namespace Factorial
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static int GetFact(int value)
        {
            var output = 1;
            
            for (var i = 1; i < value + 1; i++)
            {
                checked { output *= i; }
            }
            
            return output;
        }
    }
}