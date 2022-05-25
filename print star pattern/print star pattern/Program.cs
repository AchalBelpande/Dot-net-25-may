using System;

namespace print_star_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i=0;i<=5;i++)
            //{
            // for(int j=1;j<=i;j++)
            //{
            //  Console.Write("*");
            //}

            //Console.WriteLine("*");
            //}



            //for (int i = 0; i < 9; i++)
            //{

            // for (int j = 0; j < 9; j++)
            //{

            // if (i == 0 || j == 0 ||
            //i == 9 || j == 9 ||
            //i == j || j == 9 - i + 1)
            //{
            //   Console.Write("*");
            //}
            //else
            //{
            //  Console.WriteLine(" *");
            //}

            //}
            //Console.WriteLine(" ");
            //}

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i < j)
                        Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i > j)
                        Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
         
     }
}
