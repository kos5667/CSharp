/*
 * ���м�
 */

namespace ConsoleApp.BasicCSharp
{
    // OOP(���м�/��Ӽ�/������)
    /*
     * ���м�
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
            a = new Encapsulation().value1; //�ƹ�����
            //a = value1; //  or �θ��ӽ�
            //b = value2; // �κ���ӽ�
            //c = value3; // error
        }
    }

}
