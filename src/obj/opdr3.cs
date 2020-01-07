// using System;

// namespace CFundamentalsUdemy
// {
//     public enum ImageSize
//     {
//            Portrait,
//            Landscape

//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var result = ImageSize.Landscape;
//             int number1, number2;
            
//             Console.Write("Enter the width of the image: ");
//             number1 = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Enter the height of the image: ");
//             number2 = Convert.ToInt32(Console.ReadLine());

//             if (number1 == number2)
//             {
//                 result = ImageSize.Portrait;
//             }
            
//             else 
//             {
//                 result = ImageSize.Landscape;
//             }


//             switch (result)
//             {
//                 case ImageSize.Portrait:
//                 Console.WriteLine("Size of image is PORTRAIT");
//                 break;

//                 case ImageSize.Landscape:
//                 Console.WriteLine("Size of image is LANDSCAPE");
//                 break;

//             }
            



          
            
//         }
//     }
// }
