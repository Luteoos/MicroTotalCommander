using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.ComponentModel;


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
            
            model.AmountPaths(view.AmountOf<UserControl,IPathProvier>());//sets amount of total possible paths provided by view

            model.DirUpdate += this.DirUpdate;
            view.CurrentPathUpdate += this.CurrentPathChange;
            view.DriverUpdate += this.DriverUpdate;
            view.SelectedPathUpdate += this.SelectedPathUpdate;
            view.onClickButtonUCC += this.ButtonDecide;
            model.RunWorkerCompleted += this.TEST;

            

            //nowa funkcja
          //  Thread CopyThread = new Thread(model.Copy);
          //  CopyThread.Start();
           // if(CopyThread.ThreadState==0)
           
            

            }
         void CurrentPathChange(int which,string newpath)//Change path current, string with path, int which objects UC sende it)
        {
            model.CurrentPathModify(which ,newpath);

        }

        void TEST(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("DZIALA INVOKEEEE" + e.Result);
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
        void ButtonDecide(short which)
        {
            switch(which)
            {
                case 0:
                    model.ControlCopy();                   
                    break;
            }
           
           
            
        }
        


    }
}
