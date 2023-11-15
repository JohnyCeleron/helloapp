using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class Program
    {
        static void Greetwhite()
        {
            Console.WriteLine("hello, White");
        }

        static void GreetBlack()
        {
            Console.WriteLine("hello, Black");
        }

        static void Main(string[] args)
        {
            GreetBlack();
            Greetwhite();
            Console.WriteLine("hello everyone");
        }
    }
}
