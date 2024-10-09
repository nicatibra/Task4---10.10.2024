#region GetMinMethod(SmallestNumberFromArray)
//  GetMin adli method yaradılır. Daxil olunan arrayın ən kiçik elementini geri qaytarir(return).

namespace Task4___10._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArr = { 2, 3, 1, -3, 4 };
            Console.WriteLine("Smallest number in array is: " + GetMin(numsArr));
        }

        public static int GetMin(int[] arr)
        {
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }
    }
}
#endregion

#region AreaMethod
//  Overload Tasks :
//  Area deyə Method(lar) yaradılır.
//   1. Çevrənin sahəsi - S = p*r² (p=3)
//   2. Düzbucaqlının sahəsi - S = a*b
//   3. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
//   4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2


//namespace Task4___10._10._2024
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Area of circle: " + Area(3));
//            Console.WriteLine("Area of rectangle: " + Area(3, 4));
//            Console.WriteLine("Area of parallelepiped: " + Area(3, 4, 5));
//            Console.WriteLine("Area of parallelepiped: " + Area(3, 3, 4, 5));
//        }

//        public static double Area(double radius)
//        {
//            int pi = 3;
//            return pi * radius * radius;
//        }

//        public static double Area(double length, double width)
//        {
//            return length * width;
//        }

//        public static double Area(double length, double width, double height)
//        {
//            return 2 * (length * width + length * height + width * height);
//        }

//        public static double Area(double radius, double side1, double side2, double side3)
//        {
//            return (side1 + side2 + side3) * radius / 2;
//        }
//    }
//}
#endregion

#region Task2 version2: added Switch + userInput + IsValidTriangle Method

//namespace Task4___10._10._2024
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int choice;
//            do
//            {
//                Console.WriteLine("Calculate area of: ");
//                Console.WriteLine("0. Exit the program.");
//                Console.WriteLine("1. Circle");
//                Console.WriteLine("2. Rectangle");
//                Console.WriteLine("3. Parallelepiped");
//                Console.WriteLine("4. Circle which is inside of triangle");

//                choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.WriteLine("Enter radius of circle: ");
//                        double radius1 = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Area of circle: " + Area(radius1));
//                        Console.WriteLine(" ");
//                        break;

//                    case 2:
//                        Console.WriteLine("Enter length of rectangle: ");
//                        double length = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter width of rectangle: ");
//                        double width = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Area of rectangle: " + Area(length, width));
//                        Console.WriteLine(" ");
//                        break;

//                    case 3:
//                        Console.WriteLine("Enter length of parallelepiped: ");
//                        double lengthParallel = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter width of parallelepiped: ");
//                        double widthParallel = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter height of parallelepiped: ");
//                        double heightParallel = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Area of parallelepiped: " + Area(lengthParallel, widthParallel, heightParallel));
//                        Console.WriteLine(" ");
//                        break;
//                    case 4:
//                        Console.WriteLine("Enter radius of circle: ");
//                        double radius2 = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter 1st side of triangle: ");
//                        double side1 = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter 2st side of triangle: ");
//                        double side2 = Convert.ToDouble(Console.ReadLine());
//                        Console.WriteLine("Enter 3st side of triangle: ");
//                        double side3 = Convert.ToDouble(Console.ReadLine());

//                        if (IsValidTriangle(side1, side2, side3))
//                        {
//                            Console.WriteLine("Area of the circle which is inside of triangle: " + Area(radius2, side1, side2, side3));
//                            Console.WriteLine(" ");
//                            break;

//                        }
//                        else
//                        {
//                            Console.WriteLine("Sum of 2 sides cant be less than 3rd side.");
//                            Console.WriteLine(" ");
//                            break;
//                        }


//                    case 0:
//                        Console.WriteLine("Exited from the program.");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid input.");
//                        Console.WriteLine("");
//                        break;
//                }
//            }
//            while (choice != 0);
//        }

//        public static double Area(double radius)
//        {
//            int pi = 3;
//            return pi * radius * radius;
//        }

//        public static double Area(double length, double width)
//        {
//            return length * width;
//        }

//        public static double Area(double length, double width, double height)
//        {
//            return 2 * (length * width + length * height + width * height);
//        }

//        public static double Area(double radius, double side1, double side2, double side3)
//        {
//            return (side1 + side2 + side3) * radius / 2;
//        }

//        public static bool IsValidTriangle(double side1, double side2, double side3)
//        {
//            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}
#endregion