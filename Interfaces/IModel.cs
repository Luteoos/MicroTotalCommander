﻿
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
