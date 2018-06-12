using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Player
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public bool isStopped { get; private set; }
        //public List<Item> playerItem = new List<Item>(); //아이템은 하나만 들고 다닐 수 있게 다시 변경
        public Item playerItem = new Item();

        public Player(int _x, int _y, int _z, bool _isStopped)
        {
            X = _x;
            Y = _y;
            Z = _z;

            isStopped = _isStopped;
        }

        public void Move(float x, float y, float z)
        {
            X += x;
            Y += y;
            Z += z;

            playerItem.Move(x, y, z);
        }

        public void Grip(Item item)
        {
            playerItem = item;
        }

        public void Release() // 플레이어가 가진 아이템은 어차피 하나니까 매개변수 필요없음
        {
            playerItem = null; 
        }

        public Item CanGripItem(List<Item> items) // 유니티에서 필요..?
        {
            foreach (Item item in items)
            {
                if ((X == item.X && Y == item.Y && Z == item.Z) && (playerItem != item))
                {
                    return item;
                }
            }
            return null;
        }

        public Door CanOpenDoor(List<Door> doors)
        {
            foreach (Door door in doors)
            {
                if (X == door.X && Y == door.Y && Z == door.Z)
                {
                    return door;
                }
            }
            return null;
        }
    }
}
