using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataService service = new DataService();
            service.FindService();
            Application.Run(new IdentificationForm(service));
        }
    }
}
