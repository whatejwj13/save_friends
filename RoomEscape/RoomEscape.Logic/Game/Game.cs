using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomEscape.Logic
{
    abstract class Game //추상클래스로 비커게임과 마방진게임이 상속
    {
        //public abstract bool TriggerOnGame(Player player, Item item); //게임실행조건 - 플레이어가 아이템을 집은 경우
        public abstract bool TringgerOnGame(Player player); //플레이어의 좌표가 비커게임과 근접했을 때, 플레이어가 큐브를 모아두었을 때
        public abstract bool isCompleted();
        public abstract void Restart();

        public static Game Create(GameType gameType)
        {
            switch (gameType)
            {
                case GameType.Beaker:
                    return new BeakerGame();
                case GameType.Magic:
                    return new MaigcGame();
                default:
                    throw new NotImplementedException("Game.Create");

            }
        }
    }

    public enum GameType
    {
        Beaker,
        Magic
    }
}
