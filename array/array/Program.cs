using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = string.Empty , R = string.Empty;
            Console.Write("Enter the string");
            A = Console.ReadLine();
            if(A!=null)
            {
                for (int i =A . Length - 1; i >= 0 ; i--)
                {
                    R += A[i].ToString(); 
                   
                }
                if(R==A)
                {
                    Console.WriteLine("String is palindrom", A, R);
                }
                else
                {
                    Console.WriteLine("String is not palindrom", A, R);
                }
            }
            Console.ReadLine();

        }
    }
}
