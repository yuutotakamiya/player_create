using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program : Player
    {
        public Program(string name, int hp, int attack) : base(name, hp, attack)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
        }

        public override void ShowPlayer()
        {
            Console.WriteLine("名前: {0}, HP: {1}, 攻撃力: {2}", name, hp,attack);
        }

        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();

            // 1人目のプレイヤー情報を登録
            Console.Write("1人目のプレイヤーの名前を入力してください:");
            string name1 = Console.ReadLine();
            Console.Write("1人目のプレイヤーのHPを入力してください:");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("1人目のプレイヤーの攻撃力を入力してください:");
            int attack1 = int.Parse(Console.ReadLine());
            players.Add(new Player(name1, age1,attack1));

            // 2人目のプレイヤー情報を登録
            Console.Write("2人目のプレイヤーの名前を入力してください:");
            string name2 = Console.ReadLine();
            Console.Write("2人目のプレイヤーのHPを入力してください:");
            int hp2 = int.Parse(Console.ReadLine());
            Console.Write("2人目のプレイヤーの攻撃力を入力してください:");
            int attack2 = int.Parse(Console.ReadLine());
            players.Add(new Player(name2, hp2,attack2));


            // 登録したプレイヤー情報を表示
            foreach (Player player in players)
            {
                player.ShowPlayer();
            }

            Console.Write("ENTERキーを押してください");

            //コンソールをすぐ閉じないようにする
            Console.ReadLine();
        }
    }
}
