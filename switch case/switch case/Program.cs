using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your choice:  " );
           // int choice = Console.Read() ;
            int choice = 3;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;

                default:
                    Console.WriteLine("Your choice is wrong ");
                    break;


            }
            
        }
    }
}
