using System;
namespace TotalCOmmanderLab03
{
    public interface IModel
    {
        string[] UpdateDriver();
        void AmountPaths(short amount);
        void CurrentPathModify(int w,string p);
        void SelectedPathModify(int w, string p);

        event Action<string> ErrorSender;
    }

}
