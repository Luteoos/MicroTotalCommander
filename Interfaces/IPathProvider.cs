using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCOmmanderLab03
{
    
    public interface IPathProvier
    {

        void Refresh(string path, string[] dataD, string[] dataF);

    }
}
