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

            private int age = 10;

            //Player情報作成用の関数
            private void CreatePlayer( string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            //Player情報表示用の関数
            private void ShowPlayer()
            {
                Console.WriteLine("名前:{0}年齢:{1}");
            }
           
        }
        static void Main(string[] args)
        {
            
        }
    }
}
