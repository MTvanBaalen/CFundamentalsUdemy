/*using System;
using System.Linq;
using System.Collections.Generic;

namespace CFundamentalsUdemy
{

    class Program
    {
        static void Main(string[] args)
        {




            System.Console.WriteLine("Enter you name");


            while (true)
            {
                var input = Console.ReadLine();
                char[] names = input.ToCharArray();
                Array.Reverse(names);
                var RevName = new string(names);

                if (String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("can't reverse an empty string");
                    break;
                }

                else
                {
                    System.Console.WriteLine($"Your reversed name = {RevName}");
                    break;
                }






            }







        }









    }
}/*#1#*/