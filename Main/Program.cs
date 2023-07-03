using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoginForm2 loginForm = new LoginForm2();
            //loginForm.ShowDialog();
            //if (PublicData.Variable.IsLogin)
            //{
            //    Application.Run(new MainForm());
            //}
            Application.Run(new MainForm());
        }
    }
}
