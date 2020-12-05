using System;

namespace Less03_task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Derived();
            Console.WriteLine(obj.Method(5));

            Console.ReadKey();
        }
    }

    class Base
    {
        public virtual string Method(int i)
        {
            return "Base " + i;
        }
    }

    class Derived : Base
    {
        public override string Method(int i)
        {
            return base.Method(i) + " derived " + i;
        }
    }
}
