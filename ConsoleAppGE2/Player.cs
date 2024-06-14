using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    public class Player
    {
        //名前を入れるフィールド
        public string name = "";

        //HPを入れるフィールド
        public int hp = 0;

        //攻撃力を入れるフィールド
        public int attack = 0;

        //Player情報作成用の関数
        public virtual void CreatePlayer(string name, int hp, int attack)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;

        }

        //Player情報表示用の関数
        public virtual void ShowPlayer()
        {
            Console.WriteLine("名前:{0} HP:{1} 攻撃力:{2}", name, hp, attack);
        }

        public Player(string name, int hp, int attack)
        {
            CreatePlayer(name, hp, attack);
        }
    }
}
