using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        
        private class Player
        {

            private string name = "";

            private int age = 0;

            //Player情報作成用の関数
           private void CreatePlayer( string name, int age)
           {
                this.name = name;
                this.age = age;
           }

            //Player情報表示用の関数
            public void ShowPlayer()
            {
                Console.WriteLine("名前:{0}年齢:{1}",name,age);
            }

            public Player(string name, int age)
            {
                CreatePlayer(name, age);
            }

        }
        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();

            // 1人目のプレイヤー情報を登録
            Console.Write("1人目のプレイヤーの名前を入力してください:");
            string name1 = Console.ReadLine();
            Console.Write("1人目のプレイヤーの年齢を入力してください:");
            int age1 = int.Parse(Console.ReadLine());
            players.Add(new Player(name1, age1));

            // 2人目のプレイヤー情報を登録
            Console.Write("2人目のプレイヤーの名前を入力してください:");
            string name2 = Console.ReadLine();
            Console.Write("2人目のプレイヤーの年齢を入力してください:");
            int age2 = int.Parse(Console.ReadLine());
            players.Add(new Player(name2, age2));


            // 登録したプレイヤー情報を表示
            foreach (Player player in players)
            {
                player.ShowPlayer();
            }

            Console.ReadLine();
        }
    }
}
