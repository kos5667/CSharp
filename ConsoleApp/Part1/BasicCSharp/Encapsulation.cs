/*
 * 은닉성
 */

namespace ConsoleApp.BasicCSharp
{
    // OOP(은닉성/상속성/다형성)
    /*
     * 은닉성
     */
    class Encapsulation
    {
        public int value1 = 10;

        protected int value2 = 10;

        private int value3 = 10;

        //static void Main(string[] args)
        //{
        //}
    }

    class En : Encapsulation
    {
        int a;
        int b;
        int c;

        private void setValue()
        {
            a = new Encapsulation().value1; //아무때나
            //a = value1; //  or 부모상속시
            //b = value2; // 부보상속시
            //c = value3; // error
        }
    }

}
