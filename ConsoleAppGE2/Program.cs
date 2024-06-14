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
            Console.WriteLine("一番目のプレイヤー情報の登録");
            Console.Write("名前　>");
            string name1 = Console.ReadLine();
            int age1 = GetIntFromUser("HP >");
            int attack1 = GetIntFromUser("攻撃力 >");
            players.Add(new Player(name1, age1,attack1));

            // 2人目のプレイヤー情報を登録
            Console.WriteLine("二番目のプレイヤー情報の登録");
            Console.Write("名前　>");
            string name2 = Console.ReadLine();
            int hp2 = GetIntFromUser("HP >");
            int attack2 = GetIntFromUser("攻撃力 >");
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
       
        static int GetIntFromUser(string message)
        {
            int result;
            //整数から文字列に変換したときの条件
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("もう一度入力してください。");
                }
            }
            return result;
        }
    }
}
