using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    public class Door
    {
        public string RoomName { get; private set; }
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }
        private bool isOpened = false;

        public Door(string roomName, float x, float y, float z)
        {
            RoomName = roomName;
            X = x;
            Y = y;
            Z = z;
        }

        public bool isRightKey(string keyName) // 사용자가 들고있는 아이템(키)의 이름이(뒤에서 3글자 뺌) 문의 이름과 일치하는지
        {
            if (RoomName == keyName)
                return true;
            else
                return false;
        }

        public void Open()
        {
            isOpened = true; //문이열리는 애니메이션이 실행됨
        }
    }
}
