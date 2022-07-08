
using System;
using System.IO;
using System.Windows.Forms;
using InventoryManager.Forms;

namespace InventoryManager
{
    internal static class Program
    {
        public readonly static string SolutionDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public readonly static string DependenciesDirectory = $@"{SolutionDirectory}\Dependencies";
        public readonly static string BackupsDirectory = $@"{SolutionDirectory}\Backups";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InventoryManagerForm());
        }
    }
}


