using System.Diagnostics;
using System.Reflection.Metadata;
using HeronsNest.Algorithms;
using HeronsNest.Enums;

namespace HeronsNest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Landing main = new()
            {
                // Form Properties
                StartPosition = FormStartPosition.CenterScreen
            };

            Application.Run(main);
        }
    }
}