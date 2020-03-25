using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Параметрические_кривые
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.new toolForm()
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToolForm());
        }
    }
}
