using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Item
    {
        public string Name { get; private set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Item(string name, int x, int y, int z):this(x,y,z)
        {
            Name = name;
        }

        public Item(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Item() { }

        public void Move(float x, float y, float z)
        {
            X += x;
            Y += y;
            Z += z;
        }
        
    }
}
