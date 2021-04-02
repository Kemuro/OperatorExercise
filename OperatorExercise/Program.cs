using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            #region        
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if(a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region
            Console.WriteLine("Calculating the area of a circle:");
            AreaOfCircle();
           // Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");


            #endregion
        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = (Math.PI * radius * radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");

            return area;
        }
    }
}
