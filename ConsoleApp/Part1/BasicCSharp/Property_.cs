using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Property_
    {
        //static void Main(string[] args)
        //{
        //    Monster3 monster = new Monster3();
        //    monster.Name = "name";

        //    monster.Value = "value";

        //    Console.WriteLine(monster.Name);
        //    Console.WriteLine(monster.Value);
        //}
    }

    class Monster3
    {
        protected int hp;

        protected string name;

        protected int Mp { get; set; } = 100;
        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public string Value { get; set; }

        public int GetHp() { return hp; }
        public void SetHp(int hp) { this.hp = hp; }
    }

}
