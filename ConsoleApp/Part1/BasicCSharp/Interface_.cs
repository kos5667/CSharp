using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BasicCSharp
{
    internal class Interface_
    {
        //static void Main(string[] args)
        //{
        //    FlyableOrc orc = new FlyableOrc();
        //    DoFly(orc);

        //}

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }
    }

    abstract class Monster2
    {
        public abstract string Name { get; }
    }

    interface IFlyable
    {
        void Fly();
    }

    class Orc : Monster2
    {
        public override string Name => throw new NotImplementedException();
    }

    class FlyableOrc : Orc, IFlyable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
