// using System;
// using System.Linq;
// using System.Collections.Generic;
//
// namespace CFundamentalsUdemy
// {
//
//     class Program
//     {
//         static void Main(string[] args)
//         {
//
//             var names = new List<String>();
//             var counter = 0;
//
//             System.Console.WriteLine("Enter the name of friends who like you");
//             System.Console.WriteLine("Press only 'Enter' to show who like you.");
//
//             while (true)
//             {
//                 var input = Console.ReadLine();
//                 names.Add(input);
//                 if (!String.IsNullOrWhiteSpace(input))
//                 {
//                     counter++;
//                 }
//
//
//                 var others = (counter - 2);
//
//                 if (String.IsNullOrWhiteSpace(input))
//                 {
//                     if (counter < 1)
//                     {
//                         System.Console.WriteLine("Absolutely NOBODY likes you");
//                         break;
//                     }
//
//                     if (counter == 1)
//                     {
//                         System.Console.WriteLine($"{names[0]} likes you!");
//                         break;
//                     }
//
//                     if (counter == 2)
//                     {
//                         System.Console.WriteLine($"{names[0]} and {names[1]} like you!");
//                         break;
//                     }
//
//
//                     if (counter > 2)
//                     {
//                         System.Console.WriteLine($"{names[0]}, {names[1]} and {others} others like you!");
//                         break;
//                     }
//                 }
//
//
//
//
//             }
//
//
//
//
//
//
//
//         }
//
//
//
//
//
//
//
//
//
//     }
// }