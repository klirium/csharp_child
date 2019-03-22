using System;

namespace ChildProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Child 7");
        }
    }

    public class Child
    {
        public static void Do()
        {
            Console.WriteLine("1");
        }
    }
}
