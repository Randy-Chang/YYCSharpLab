using Project_LBTToolBox.Scopes;
using System;
using System.Windows.Forms;

namespace Project_LBTToolBox
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Scope scopes = new Scope();
            Application.Run(Scope.mainForm);
        }
    }
}