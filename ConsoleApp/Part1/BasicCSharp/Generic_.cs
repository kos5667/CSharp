using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Generic_
    {
        //class MyList<T> where T : struct
        class MyList<T> where T : class
        //class MyList<T> where T : Monster
        {
            T[] array = new T[10];

            public T Getitem(int i)
            {
                return array[i];
            }
        }

        //static void Main(string[] args)
        //{
        //    MyList<int> intList = new MyList<int>();
        //    MyList<short> shortList = new MyList<short>();
        //    MyList<Monster> monsterList = new MyList<Monster>();
        //}

        class Monster
        {

        }
    }
}
