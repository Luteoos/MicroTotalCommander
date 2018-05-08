namespace TotalCOmmanderLab03
{
    sealed class ModelData
    {

       static private string[] Paths;
       static private int[] Enum;

        public ModelData(string source,string target, int src, int trgt )
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
