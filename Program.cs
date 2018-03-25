using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TotalCOmmanderLab03
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Model model = new Model();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWIndow view = new MainWIndow();

            Controler controler = new Controler(ref view,ref model);

            

            Application.EnableVisualStyles();
            
            Application.Run(view);
        }
    }
}
