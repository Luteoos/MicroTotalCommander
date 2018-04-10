using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;



namespace TotalCOmmanderLab03
{
     class Model: IModel //BackgroundWorker,
    {
        
        
        private string[] currentpath, selectedpath;
        private bool bIsNewDir=true;
        private int LastSelected;
       // private bool flagCopy=false;

        #region events
        //(which UC haveto get it, path to directory, dirs in directory files in drectory)
        public delegate void evDirUpdate(int whichUC, string path,string[] a, string[] b);
        public event evDirUpdate DirUpdate;

        public event  Action<string> ErrorSender;
        public event Action OperationComplete;

        //public delegate void evAfterCopyReload();
        //public event evAfterCopyReload ReloadAfterOperation;


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
            Debug.WriteLine("PathModify" + which);
            if (!path.Equals(""))
            {
                if (path.Contains(@":\"))
                {
                    selectedpath[which] = "";//clears selected path
                    currentpath[which] = "";
                    currentpath[which] = path;
                    DirUpdate(which, currentpath[which], System.IO.Directory.GetDirectories(currentpath[which]),
                        System.IO.Directory.GetFiles(currentpath[which]));

                    //tu pobiranie file i dirs i wysyalanie eventem do widoku
                }
                else
                {
                    try
                    {

                        DirUpdate(which, currentpath[which] + path + @"\",
                            System.IO.Directory.GetDirectories(currentpath[which] + path),
                            System.IO.Directory.GetFiles(currentpath[which] + path));

                        bIsNewDir = true;
                        currentpath[which] += path + @"\";//tu potem wczytanie plikow w tej lokacji i wyslanie ich do view
                        selectedpath[which] = "";//clears selected after getting into dir
                    }
                    catch (IOException)
                    {
                        try
                        {
                            Debug.WriteLine("model excpetion opening file" + currentpath[which]);
                            Process.Start(currentpath[which] + path);
                            bIsNewDir = false;

                        }
                        catch (System.ComponentModel.Win32Exception)
                        {
                            ErrorSender("Driver not found!");
                            //MessageBox.Show("Drive not Found, choose another Drive","Error");
                        }

                    }
                }
            }
            //Debug.WriteLine("Model currentpath: "+currentpath[which]);        
        }    
        
        public void SelectedPathModify(int which,string path)//trzyma selected path danego ucView
        {
            selectedpath[which] = currentpath[which] + path;
            LastSelected=which;
            bIsNewDir = false;

            Debug.WriteLine("Model selectedd: " + selectedpath[which] + " " + which);
        }

        private  void Copy(object data)//copies to next path
        {
            ModelData Data = data as ModelData;
            if (Data.GetPath(1).Contains(@":\"))
            {
                if (Data.GetPath(0) != Data.GetPath(1))
                {
                    try
                    {
                        //Debug.WriteLine("COPY COMPLETED");
                        File.Copy(Data.GetPath(0), Data.GetPath(1));
                        OperationComplete();
                    }
                    catch (Exception e)
                    {
                        //Debug.WriteLine("Exception copy " + e.Message);
                        ErrorSender("Copy Failed! "+e.Message);
                    }
                }
            }
        }
        private void Delete(object data)
        {
            ModelData Data = data as ModelData;
            if (File.Exists(Data.GetPath(0)))
            {
                try
                {
                    File.Delete(Data.GetPath(0));
                    OperationComplete();
                }catch(Exception e)
                {
                    ErrorSender("Delete Failed! " + e.Message);
                }
            }
            else
            {
                ErrorSender("Wrong path!");
            }
        }

        private void Move(object data)
        {
            ModelData Data = data as ModelData;
            if (Data.GetPath(1).Contains(@":\"))
            {
                if (Data.GetPath(0) != Data.GetPath(1))
                {
                    try
                    {
                        //Debug.WriteLine("COPY COMPLETED");
                        File.Move(Data.GetPath(0), Data.GetPath(1));
                        OperationComplete();
                    }
                    catch (Exception e)
                    {
                        //Debug.WriteLine("Exception copy " + e.Message);
                        ErrorSender("Move Failed! " + e.Message);
                    }
                }
            }
        }

        public void ControlOperation(short option)
        {
           // Debug.WriteLine("ControlCopy" );
                if(!bIsNewDir)
            {
                int Target = (LastSelected + 1) % currentpath.Length;
                ModelData Data = new ModelData(selectedpath[LastSelected],
                   currentpath[Target] + Path.GetFileName(selectedpath[LastSelected]), LastSelected, Target);

                switch(option)
                {
                    case 0:
                        Thread Copy = new Thread(this.Copy) { IsBackground = true };
                        Copy.Start(Data);
                        break;
                    case 1:
                        Thread Move = new Thread(this.Move) { IsBackground = true };
                        Move.Start(Data);
                        break;
                    case 2:
                        Thread Delete = new Thread(this.Delete) { IsBackground = true };
                        Delete.Start(Data);
                        break;


                }
              
            }
               
            
               
            
            

        }

       /* public int[] CopyReloadData()//[source,target]
        {
            int[] tabdata = new int[2];
             tabdata[1]= (LastSelected + 1) % currentpath.Length; 
             tabdata[0] = LastSelected;
            return tabdata;

        }
        public string EHH(int i)
        {
            return currentpath[i];
        }*/
    }
}
