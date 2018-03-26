using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCOmmanderLab03
{
     partial class UCCopyDeleteCut : UserControl
    {
        public delegate void evOnClickButtons(short  which);
        public event evOnClickButtons onClick;

        public UCCopyDeleteCut()
        {
            InitializeComponent();
        }

        void onClickButton(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch(button.Name)
            {
                case "bCopy":
                    onClick(0);
                    break;

            }
        }

    }
}
