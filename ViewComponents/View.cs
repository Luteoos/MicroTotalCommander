using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TotalCOmmanderLab03
{
    partial class MainWIndow : Form
    {

        #region Delegates
        public delegate void _DRefreshAll();
        public _DRefreshAll _RefreshAll;

        public delegate void evonClickUCButton(short which);
        public event evonClickUCButton onClickButtonUCC;

        public delegate void evCurrentPathUpdate(int which, string path);
        public event evCurrentPathUpdate CurrentPathUpdate;

        public delegate string[] evDriverUpdate();
        public event evDriverUpdate DriverUpdate;

        public delegate void evSelectedPathUpdate(int which, string path);
        public event evSelectedPathUpdate SelectedPathUpdate;
        #endregion

        public MainWIndow()
        {
            InitializeComponent();
            int i = 0;
            this._RefreshAll = this.RefreshAll;
            foreach (UserControl comp in this.Controls)
            {
                if (comp is UCTotalComanderView)
                {
                    var uctcomponent = comp as UCTotalComanderView;

                    uctcomponent.Index = i;
                    i++;

                    uctcomponent.triggerReload += this.Reload;
                    uctcomponent.ReloadDrivers += this.DriversReload;
                    uctcomponent.ReSelect += this.ReSelect;
                }
                else if (comp is UCCopyDeleteCut)
                {
                    UCCopyDeleteCut uccComponent = comp as UCCopyDeleteCut;
                    uccComponent.onClick += this.OnClick;
                }
            }
        }

        private void RefreshAll()
        {
            foreach (UserControl comp in this.Controls)
            {         
                if(comp is UCTotalComanderView)
                {
                    var UTCC=comp as UCTotalComanderView;
                    CurrentPathUpdate(UTCC.Index, UTCC.CurrentPath);
                }
            }
        }

        public void ErrorShow(string e)
        {
            MessageBox.Show(e, "Error");
        }

        void OnClick(short which)
        {
            onClickButtonUCC(which);
        }

        private void ReSelect(int TabIndex, string path)
        {
            SelectedPathUpdate(TabIndex, path);
        }

        private void Reload(int TabIndex, string path)
        {
            CurrentPathUpdate(TabIndex, path);
        }
        private string[] DriversReload(object sender)
        {
            return DriverUpdate();
        }

        public void UpdateView(int which, string path, string[] dir, string[] files)
        {
            var UserControlTCV = this.Controls.OfType<UCTotalComanderView>().Where(c => c.Index == which).First();
            UserControlTCV.Refresh(path, dir, files);
        }

        public short AmountOf<type,typeOfInputter>()
        {
            ComponentCount<type,typeOfInputter> CompAmount = new ComponentCount<type,typeOfInputter>(this);
            return CompAmount.AmountOf();
        }
    }

}

