using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCOmmanderLab03
{
    public interface IModel
    {
        void AmountPaths(short amount);
        void CurrentPathModify(int w,string p);
        void SelectedPathModify(int w, string p);
        string[] UpdateDriver();
    }
}
