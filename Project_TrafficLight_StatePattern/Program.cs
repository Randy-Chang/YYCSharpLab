using System;
using System.Windows.Forms;
using TrafficLight_FSM_Project.Scopes;

namespace TrafficLight_StatePattern
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Scope scope = new Scope();
            Application.Run(Scope.mainForm);
        }
    }
}
