using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Item
    {
        private static int _counter;
        public int Id { get; private set; }
        public int v { get; set; } // value
        public int w { get; set; } // weight
        public Item()
        {
            Id = ++_counter;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}  v: {1}  w: {2}",
                                 Id, v, w);
        }
    }
}
