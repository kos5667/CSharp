// See https://aka.ms/new-console-template for more information

/*
 * 다형성
 */

namespace ConsoleApp.BasicCSharp
{
    // OOP(은닉성/상속성/다형성)
    /*
     * 상속성
     * 
     * CAST
     * is true,false
     * as is true일시 Cast false 일시 null
     */
    class Polymorphism
    {
        public virtual void move()
        {
            Console.WriteLine("이동!");
        }
        public virtual void attack()
        {
            Console.WriteLine("이동!");
        }
        //static void Main(string[] args)
        //{

        //}
    }

    class Cast : Move
    {

        static void Case(Move move)
        {
            Polymorphism pr = move as Polymorphism;

            Polymorphism? mr = move as Cast;
        }
    }

    class Move : Polymorphism
    {

        public override void move()
        {
            //  부모 move 재사용.
            base.move();
        }
        // sealed 여기서만 사용가능
        public sealed override void attack()
        {
            //  부모 move 재사용.
            base.attack();
        }
    }
}