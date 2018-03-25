using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace TotalCOmmanderLab03
{
     class Controler
    {
        MainWIndow view;
        Model model;

        
        public Controler(ref MainWIndow a, ref Model b)
            {
            this.view = a;
            this.model = b;
            
            model.AmountPaths(view.AmountOf<IPathProvier>());//sets amount of total possible paths provided by view

            model.DirUpdate += this.DirUpdate;
            view.CurrentPathUpdate += this.CurrentPathChange;
            view.DriverUpdate += this.DriverUpdate;
            view.SelectedPathUpdate += this.SelectedPathUpdate;

            }
         void CurrentPathChange(int which,string newpath)//Change path current, string with path, int which objects UC sende it)
        {
            model.CurrentPathModify(which ,newpath);

        }

        void SelectedPathUpdate(int which,string path)
        {
            model.SelectedPathModify(which, path);
        }

        string[] DriverUpdate()
        {
           
            return model.UpdateDriver();
           
        }

        void DirUpdate(int which,string path,string[] dir,string[] files)
        {
            //tu view i funkcja update dir
            view.UpdateView(which, path, dir, files);
        }
        


    }
}
