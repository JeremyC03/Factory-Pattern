using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MeatballSubSandwich : IFood
    {
        public int Price { get; set; }
        public bool ToGo { get; set; }

        public void Description()
        {
            Console.WriteLine("A sandwich is a nice choice."); ;
        }
    }
}
