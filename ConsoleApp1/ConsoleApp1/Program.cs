using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 20;
            Console.WriteLine(" person age is:"  +A);

            if (A >= 18)
            {
                Console.WriteLine("The person is able to vote ");

                if (A > 60)
                {
                    Console.WriteLine("He is the senior citizen");
                }
            }
            else
            {
                Console.WriteLine("The person not able to vote");
            }
           
        }
    }
}
