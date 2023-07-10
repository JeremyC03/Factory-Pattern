using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IFood
    {
        public int Price { get; set; }
        public bool ToGo { get; set; }
        public void Description();
    }
}
