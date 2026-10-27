using System;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.GUI;

namespace Lab06_ThreeLayerMemory
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmQuanLySinhVien());
        }
    }
}