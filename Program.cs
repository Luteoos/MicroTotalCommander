using System;
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
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            MainWIndow view = new MainWIndow();
            Controler controler = new Controler(ref view,ref model);

            Application.EnableVisualStyles();
            Application.Run(view);
        }
    }
}
