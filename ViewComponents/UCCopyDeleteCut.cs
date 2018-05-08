using System;
using System.Windows.Forms;

namespace TotalCOmmanderLab03
{
    partial class UCCopyDeleteCut : UserControl
    {

        public delegate void evOnClickButtons(short which);
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
                case "Copy":
                    onClick(0);
                    break;
                case "Move":
                    onClick(1);
                    break;
                case "Delete":
                    onClick(2);
                    break;
            }
        }

    }
}
