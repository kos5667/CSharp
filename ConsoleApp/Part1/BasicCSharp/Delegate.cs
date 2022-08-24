using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Delegate
    {

        static void OnInputTest()
        {
            Console.WriteLine("input Received!");
        }
        // *****
        // Delegate (대리자) 
        // Event
        //static void Main(string[] args)
        //{
        //    InputManager inputManager = new InputManager();
        //    inputManager.InputKey += OnInputTest;

        //    while (true)
        //    {
        //        inputManager.Update();
        //    }
        //    //ButtonPressed(TestDelegate);
        //}

        static void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate!");
            return 0;
        }
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 : int, 입력:void
        // OnClicked 이 delegate 형식의 이름이다.
        delegate int OnClicked();
    }

}
