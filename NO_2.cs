using System;

namespace Test_NO._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            x = a;
            y = b;

            while (x != y)

            {
                if (x < y)
                {
                    x = x + a;

                }
                else
                {
                    y = y + b;
                }
            }
            Console.Write("{0}", x);
        }
    }
}
