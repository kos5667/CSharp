using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Exception_
    {
        static void run()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

                throw new TestException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
        }

        //static void Main(string[] args)
        //{
        //    run();
        //}
        class TestException : Exception
        {
        }
    }

    
}
