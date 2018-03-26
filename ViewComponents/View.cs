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
        public delegate void evonClickUCButton(short which);
        public event evonClickUCButton onClickButtonUCC;

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
            foreach (UserControl comp in this.Controls)
            {
                
                if (comp is UCTotalComanderView)
                {
                    var uctcomponent = comp as UCTotalComanderView;
                    uctcomponent.triggerReload += this.Reload;
                    uctcomponent.ReloadDrivers += this.DriversReload;
                    uctcomponent.ReSelect += this.ReSelect;
                }
                else if (comp is UCCopyDeleteCut)
                {
                    UCCopyDeleteCut uccComponent = comp as UCCopyDeleteCut;
                    uccComponent.onClick += this.onClick;

                }
                //Debug.WriteLine("Component initial {0}  {1}", uctcomponent.GetHashCode(), uctcomponent.GetType());


            }

        }

        void onClick(short which)
        {
            onClickButtonUCC(which);
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

        public short AmountOf<type,typeOfInputter>()
        {
            ComponentCount<type,typeOfInputter> CompAmount = new ComponentCount<type,typeOfInputter>(this);
            return CompAmount.AmountOf();
        }

        

        
    }
}

