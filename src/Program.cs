using System;
using System.Linq;

namespace CFundamentalsUdemy
{
  
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a bunch of numbers, seperated by comma: ");
            var allDigits = Console.ReadLine().Split(',');
            int[] digits = allDigits.Select(a => Convert.ToInt32(a)).ToArray();

            var Highest = digits.Max();

            System.Console.WriteLine($"The highest number is: {Highest}");

  
        
            
        }
        
          

          

          
        
        
    }
}
