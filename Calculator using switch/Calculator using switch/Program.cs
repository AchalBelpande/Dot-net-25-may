using System;

namespace Calculator_using_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two value");
            int a = (Console.Read()); 
             int   b = (Console.Read());
            int c;

           // Console.WriteLine("A=2,B=4");
            Console.WriteLine("want to do ->  1.Add  :  2.Sub  :   3.Division  : 4.Multiplication");
            int choice = (Console.Read());
            switch(choice)
                {
                case 1:
                    c = a + b;
                    Console.WriteLine("Addition ->" + c);
                    break;

                case 2:
                    c = a - b;
                    Console.WriteLine("Substraction ->" + c);
                    break;

                case 3:
                    c = a / b;
                    Console.WriteLine("Division ->" + c);
                    break;

                case 4:
                    c = a * b;
                    Console.WriteLine("Multiplication ->" + c);
                    break;

                default:
                    Console.WriteLine("Your choice is wrong");
                    break;
            }


            Console.WriteLine("Hello World!");
        }
    }
}
