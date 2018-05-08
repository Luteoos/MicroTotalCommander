using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalCOmmanderLab03
{
    //generic component of T count how mayn T components in Controls, and type of U
    internal class ComponentCount<T,U>
    {
        private Control owner;

        public ComponentCount(Control owner)
        {
            this.owner = owner;
        }

        public short AmountOf()
        {
            short amount = 0;
            
            foreach (T instance in owner.Controls)
            {
                if(instance is U)
                {
                    amount++;
                }
            }
            return amount;
        }
    }

}
