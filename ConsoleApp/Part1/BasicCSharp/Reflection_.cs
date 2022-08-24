using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Reflection_
    {
        class Important : System.Attribute {

            string message;
            public Important(string message)
            {
                this.message = message;
            }
        }

        class Monster
        {
            //public string Name { get; set; }
            //public string Description { get; set; }

            // 
            [Important("Very Important")]
            public int hp;
        }

        static void run()
        {
            Monster monster = new Monster();
            Type type = monster.GetType();

            var fields = type.GetFields(
                            System.Reflection.BindingFlags.Public
                          | System.Reflection.BindingFlags.NonPublic
                          | System.Reflection.BindingFlags.Static
                          | System.Reflection.BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }
        }

        //static void Main(string[] args)
        //{
        //    run();
        //}
    }
}
