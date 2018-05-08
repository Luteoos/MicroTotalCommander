using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TotalCOmmanderLab03
{
    partial class UCTotalComanderView : UserControl, IPathProvier
    {

#region Delegates
        public delegate void evReload(int TabIndex, string path);
        public event evReload triggerReload;

        public delegate string[] evReloadDrivers(object sender);
        public event evReloadDrivers ReloadDrivers;

        public delegate void evReSelect(int TabIndex, string path);
        public event evReSelect ReSelect;
#endregion

        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
 
        public UCTotalComanderView()
        {
            InitializeComponent();
        }
  
        public string CurrentPath
        {
            get
            {
                return textPath.Text;
            }
            set
            {
                textPath.Text =  value;
            }
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drivers = sender as ComboBox;

            if(drivers.SelectedIndex>=0)
            {
                triggerReload(this.Index,drivers.SelectedItem.ToString());
            }
            else
            {
                Debug.WriteLine("smth went wrong");
            }
        }

        public void Refresh(string path,string[] dataD,string[] dataF)
        {
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
               ReSelect(this.Index, dirs.SelectedItem.ToString());
            }
            else
            {
               // Debug.WriteLine("smth went wrong");
            }
        }

        private void listDrivesInclude_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sender is ListBox)
            {
                ListBox drivers=sender as ListBox;
                
                if (drivers.SelectedIndex >= 0)
                {
                    triggerReload(this.Index, drivers.SelectedItem.ToString());
                }
                else
                {
                   //Debug.WriteLine("smth went wrong");
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
