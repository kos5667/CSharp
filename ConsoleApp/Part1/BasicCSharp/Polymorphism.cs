// See https://aka.ms/new-console-template for more information

/*
 * ������
 */

namespace ConsoleApp.BasicCSharp
{
    // OOP(���м�/��Ӽ�/������)
    /*
     * ��Ӽ�
     * 
     * CAST
     * is true,false
     * as is true�Ͻ� Cast false �Ͻ� null
     */
    class Polymorphism
    {
        public virtual void move()
        {
            Console.WriteLine("�̵�!");
        }
        public virtual void attack()
        {
            Console.WriteLine("�̵�!");
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
            //  �θ� move ����.
            base.move();
        }
        // sealed ���⼭�� ��밡��
        public sealed override void attack()
        {
            //  �θ� move ����.
            base.attack();
        }
    }
}