// See https://aka.ms/new-console-template for more information

namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
    /*
     * 상속성
     */
    class Player
    {
        static public int counter = 1;
        public int hp;
        public int attack;

        public Player ()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            Console.WriteLine("Player hp 생성자 호출!");
        }
    }

    class A : Player
    {
        public A ()
        {
            Console.WriteLine("A 생성자 호출!");
        }
    }

    class B : Player
    {
        int hp;
        public B() : base(100)
        {
            this.hp = 10;
            base.hp = 100;
            Console.WriteLine("B 생성자 호출!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
        }
    }

}