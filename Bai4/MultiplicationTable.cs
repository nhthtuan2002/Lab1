using System;

namespace Bai4
{
    public class MultiplicationTable
    {
        public void BangCuuChuong()
        {
            Console.WriteLine("Pleses enter N: ");
            var number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                var result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
    }
}