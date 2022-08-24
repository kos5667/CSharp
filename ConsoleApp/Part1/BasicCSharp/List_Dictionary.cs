using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class List_Dictionary
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int>();

        //    Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
        //    for(int i=0; i< 10000; i++)
        //    {
        //        dic.Add(i, new Monster(i));
        //    }

        //    //Monster mon = dic[3000];
        //    Monster mon;
        //    bool fount = dic.TryGetValue(100, out mon);
        //}

    }

    class Monster
    {
        public Monster(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
