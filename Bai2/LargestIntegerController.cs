using System;

namespace Lab1
{
    public class LargestIntegerController
    {
        public void LargestInteger()
        {
            LargestInteger number = new LargestInteger();
            Console.WriteLine("Please enter number 1: ");
            number.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2: ");
            number.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 3: ");
            number.Num3 = Convert.ToInt32(Console.ReadLine());
            if (number.Num1 > number.Num2) {
                if (number.Num1 > number.Num3) {
                    Console.Write("the first integer is the largest integer.");
                } else {
                    Console.Write("the third integer is the largest integer.");
                }
            }
            else if (number.Num2 > number.Num3)
                Console.Write("the second integer is the largest integer.");
            else
                Console.Write("the third integer is the largest integer.");
        }
    }
}