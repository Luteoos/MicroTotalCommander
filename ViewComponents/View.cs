using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace TotalCOmmanderLab03
{


    partial class MainWIndow : Form
    {
        //List<UCTotalComanderView> ListControls;

        public delegate void evCurrentPathUpdate(int which, string path);
        public event evCurrentPathUpdate CurrentPathUpdate;

        public delegate string[] evDriverUpdate();
        public event evDriverUpdate DriverUpdate;

        public delegate void evSelectedPathUpdate(int which, string path);
        public event evSelectedPathUpdate SelectedPathUpdate;

        public MainWIndow()
        {

            InitializeComponent();

            // Debug.WriteLine(ComponentCollection.ReferenceEquals(ucTotalComanderView1, ucTotalComanderView2));

            //AADD METHOD HERE TO COUNT ALL UCTOTALCOMMANDERVIEW OBJECTS AND INITIALIZE SAME AMOUNT IN MODEL
            foreach (UCTotalComanderView uctcomponent in this.Controls)
            {
                //Debug.WriteLine("Component initial {0}  {1}", uctcomponent.GetHashCode(), uctcomponent.GetType());
                uctcomponent.triggerReload += this.Reload;
                uctcomponent.ReloadDrivers += this.DriversReload;
                uctcomponent.ReSelect += this.ReSelect;


               

            }

            //ucTotalComanderView1.CurrentPath = @"c:\";//@ znak porzucenia= bez znakow specjalnuch

        }


        private void ReSelect(int TabIndex, string path)
        {

            SelectedPathUpdate(TabIndex, path);

        }

        private void Reload(int TabIndex, string path)//zaleznie ktore okno wysyla to taki int przekazany dalej do control i model
        {
            CurrentPathUpdate(TabIndex, path);

        }
        private string[] DriversReload(object sender)
        {

            return DriverUpdate();
        }

        public void UpdateView(int which, string path, string[] dir, string[] files)
        {


            //zwraca ten obiekt uctotalcomanderview ktory ma tabindex=which
            var UserControlTCV = this.Controls.OfType<UCTotalComanderView>().Where(c => c.TabIndex == which).First();
            UserControlTCV.Refresh(path, dir, files);


        }

        public short AmountOf<type>()
        {
            ComponentCount<type> CompAmount = new ComponentCount<type>(this);
            return CompAmount.AmountOf();
        }

        

        
    }
}

