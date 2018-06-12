using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Beaker : Item
    {
        public Beaker(int capacity, int liter,int x, int y, int z) : base(x, y, z)
        {
            Capacity = capacity;
            Liter = liter;
        }

        public Beaker(int capacity, int liter) 
        {
            Capacity = capacity;
            Liter = liter;
        }

        public int Capacity { get; private set; }

        public int Liter { get; set; }
    }
}
