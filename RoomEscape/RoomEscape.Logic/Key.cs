using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Key : Item
    {
        public string KeyName { get; }

        public Key(string name, int x, int y, int z) : base(name,x, y, z)
        {
            KeyName = name;
        }
    }
}
