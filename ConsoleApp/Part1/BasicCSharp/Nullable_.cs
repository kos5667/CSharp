using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    // Nullable -> Null + able
    internal class Nullable_ {
        static int Find() {
            return 0;
        }
        class Monster {
            public int Id { get; set; }
        }

        static void run() {
            int? number = null;
            //number = 3;
            number = null;

            if (number.HasValue) {
                int a = number.Value;
                Console.WriteLine(a);
            }

            //int a = number.Value;
            //Console.WriteLine(a);

            int b = number ?? 0;
            Console.WriteLine(b);


            Monster monster = null;

            int? id = monster?.Id;
        }

        //static void Main(string[] args) {
        //    run();
        //}

        
    }
}
