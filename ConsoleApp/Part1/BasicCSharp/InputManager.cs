using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    // Observer Pattern
    internal class InputManager
    {
        // callback
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                InputKey();
            }
        }
    }
}
