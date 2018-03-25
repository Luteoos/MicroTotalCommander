using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace TotalCOmmanderLab03
{
    partial class UCTotalComanderView : UserControl,IPathProvier
    {

        public delegate void evReload(int TabIndex,string path);
        public event evReload triggerReload;//triggers reload function in Form1
        
        public delegate string[] evReloadDrivers(object sender);
        public event evReloadDrivers ReloadDrivers;//return string of drivers

        public delegate void evReSelect( int TabIndex, string path);
        public event evReSelect ReSelect;
        
            
        public UCTotalComanderView()
        {
            
            InitializeComponent();

            //THREADING
            //Thread MThread = new Thread(this.ThreadTest);
            //MThread.Start(this);
            


        }

       /* public void ThreadTest(object data)
        {
           
            Debug.WriteLine("THREAD TEST"+data);
        }
        */
        public string CurrentPath//update textbox
        {
            get
            {
                return textPath.Text;
            }
            set {
                   textPath.Text =  value;
               }
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)//wybiera litere dysku
        {
            
            ComboBox drivers = sender as ComboBox;
           // textPath.Text = "";//czysci text box, musi tak byc 

            if(drivers.SelectedIndex>=0)
            {
                
                // CurrentPath= drivers.SelectedItem.ToString();
                triggerReload(this.TabIndex,drivers.SelectedItem.ToString());
            }
            else
            {
                
                Debug.WriteLine("smth went wrong");
            }

        }

        public void Refresh(string path,string[] dataD,string[] dataF)
        {
            Debug.WriteLine("refresh here");
            CurrentPath = path;
            listDrivesInclude.Items.Clear();
            for (int i = 0; i < dataD.Length; i++)
            {
                listDrivesInclude.Items.Add(Path.GetFileName(dataD[i]));
            }
            for (int i = 0; i < dataF.Length; i++)
            {
                listDrivesInclude.Items.Add(Path.GetFileName(dataF[i]));
            }

        }

        private void listSelected(object sender, EventArgs e)//trigers on selection change
        {
          
            ListBox dirs = sender as ListBox;
            if (dirs.SelectedIndex >= 0)
            {
               ReSelect(this.TabIndex, dirs.SelectedItem.ToString());
            }
            else
            {
                Debug.WriteLine("smth went wrong");
            }
        }

        private void listDrivesInclude_MouseDoubleClick(object sender, MouseEventArgs e)//doubleclick wrzuca wglad/otwiera
        {
            
            if (sender is ListBox)
            {
                ListBox drivers=sender as ListBox;
                
                if (drivers.SelectedIndex >= 0)
                {
                    triggerReload(this.TabIndex, drivers.SelectedItem.ToString());

                }
                else
                {
                    Debug.WriteLine("smth went wrong");
                }
            }
        }

        private void cbDrives_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBox cbDrives = sender as ComboBox;
            string[] drivers;
            drivers= ReloadDrivers(this);
            if (drivers != null)
            {
                cbDrives.Items.Clear();
                cbDrives.Items.AddRange(drivers);
            }

        }
    }
  
    

}
