using System;

namespace ConsoleApplication1
{
    public class Factor
    {
        public void ThuaSo()
        {
            int result = 1;
            for (int i = 1; i < 21; i++)
            {
                result = result * i;
                Console.WriteLine($"The factor of the number {i} is: {result}");
                
            }
        }
    }
}