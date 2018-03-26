using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCOmmanderLab03
{
    sealed class ModelData
    {
        private string[] Paths;
        private int[] Enum;

        public ModelData(string source,string target, int src, int trgt)
        {
            Paths = new string[2];
            Enum = new int[2];
            Paths[0] = source;
            Paths[1] = target;
            Enum[0] = src;
            Enum[1] = trgt;
        }
        public string GetPath(int i)
        {
            return Paths[i];
        }
        public int GetEnum(int i)
        {
            return Enum[i];
        }
    }
}
