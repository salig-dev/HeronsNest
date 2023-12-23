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
            Trie x = new();
            x.Insert("machina");
            x.Insert("machinable");
            x.Insert("machination");

            var r = x.Search("machine");
            if (r != null)
            {
                Debug.WriteLine("Found");
            } else
            {
                Debug.WriteLine("Not Found");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Landing());
        }
    }
}