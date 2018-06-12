using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Cube : Item
    {
        public Cube(int cubeNum,int x, int y, int z) : base(x, y, z)
        {
            CubeNum = cubeNum;
        }

        public Cube(int cubeNum)
        {
            CubeNum = cubeNum;
        }

        public int CubeNum { get; set; }
    }
}
