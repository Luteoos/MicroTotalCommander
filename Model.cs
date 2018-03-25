using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;


namespace TotalCOmmanderLab03
{
     class Model: IModel
    {
        
        
        private string[] currentpath, selectedpath;
        private int last;//keps int from which object was last selected item
        private int LastSelected { get => last; set => last = value; }

        #region events
        //(which UC haveto get it, path to directory, dirs in directory files in drectory)
        public delegate void evDirUpdate(int whichUC, string path,string[] a, string[] b);
        public event evDirUpdate DirUpdate;


#endregion

        
        public Model()
        {    
        }

        public void AmountPaths(short amount)
        {
            Debug.WriteLine(amount + " TYLE SCIEZEK MOZLIWEYCH");
            currentpath = new string[amount];
            selectedpath = new string[amount];
        }

         public string[] UpdateDriver()
        {
            DriveInfo[] Infodrivers;
            string[] drivers;
            
            Infodrivers = DriveInfo.GetDrives();
            drivers = new string[Infodrivers.Length];
            for (int i = 0; i < Infodrivers.Length; i++)
            {
                if (Infodrivers[i].IsReady)
                {
                    drivers[i] = Infodrivers[i].Name;
                }
                else
                {
                    drivers[i] = "!";
                }
            }
            return drivers;
        }
        

        public void CurrentPathModify(int which,string path)//(path to update, which UCTotal..)
        {
            Debug.WriteLine("Tu model");
            if(path.Contains(@":\"))
            {
                selectedpath[which] = "";//clears selected path
                currentpath[which] = "";
                currentpath[which] = path;
                DirUpdate(which,currentpath[which],System.IO.Directory.GetDirectories(currentpath[which]), System.IO.Directory.GetFiles(currentpath[which]));
                //tu pobiranie file i dirs i wysyalanie eventem do widoku
            }
            else
            {
                try
                {

                    DirUpdate(which,currentpath[which]+path+@"\",System.IO.Directory.GetDirectories(currentpath[which]+path), System.IO.Directory.GetFiles(currentpath[which] + path));
                    currentpath[which] += path + @"\";//tu potem wczytanie plikow w tej lokacji i wyslanie ich do view

                    selectedpath[which] = "";//clears selected after getting into dir
                }
                catch(IOException)
                {
                    try
                    {
                        Debug.WriteLine("model excpetion opening file" + currentpath[which]);
                        Process.Start(currentpath[which] + path);
                    }catch(System.ComponentModel.Win32Exception)
                    {
                        MessageBox.Show("Drive not Found, choose another Drive","Error");
                    }
                    
                }
            }
            Debug.WriteLine("Model currentpath: "+currentpath[which]);
            
        }    
        
        public void SelectedPathModify(int which,string path)//trzyma selected path danego ucView
        {
            selectedpath[which] = currentpath[which] + path;
            LastSelected=which;

            Debug.WriteLine("Model selectedd: " + selectedpath[which] + " " + which);
        }
    }
}
