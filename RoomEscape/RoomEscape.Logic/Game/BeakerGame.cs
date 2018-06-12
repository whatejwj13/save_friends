using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    class BeakerGame : Game
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public BeakerGame()
        {
            _beakers = new Dictionary<string, Beaker>();

            _beakers.Add("A", new Beaker(8, 8));
            _beakers.Add("B", new Beaker(5, 0));
            _beakers.Add("C", new Beaker(3, 0));

            float _x = X;
            float _y = Y;
            float _z = Z;
        }

        private Dictionary<string, Beaker> _beakers;

        public void Move(string from, string to)
        {
            Move(_beakers[from], _beakers[to]);
        }

        public void Move(char from, char to)
        {
            Move(_beakers[from.ToString()], _beakers[to.ToString()]);
        }

        private void Move(Beaker from, Beaker to)
        {
            int liter = Math.Min(from.Liter, to.Capacity - to.Liter);

            to.Liter += liter;
            from.Liter -= liter;
        }

        public int this[string name]
        {
            get { return GetLiter(name); }
        }

        public int GetLiter(string name)
        {
            return _beakers[name].Liter;
        }

        public override bool isCompleted()
        {
            return _beakers["A"].Liter == 4 && _beakers["B"].Liter == 4;
        }

        public override void Restart()
        {
            _beakers["A"].Liter = 8;
            _beakers["B"].Liter = 0;
            _beakers["C"].Liter = 0;
        }

        public override bool TringgerOnGame(Player player)
        {

            float k = player.X + player.Z - this.X + this.Z;

            //플레이어와 비커게임의 y축이 같고 플레이어의 x+z축의 값과 비커게임의 x+z축의 차가 -1보다 크거나 같고 1보다 같거나 작으면 true 아니면 false
            if (player.Y == this.Y && k <= 1 && k >= -1)
                return true;
            else return false;
        }
    }
}
