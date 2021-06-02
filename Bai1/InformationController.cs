using System;
using System.Text;

namespace Bai1
{
    public class InformationController
    {
        public static void Information()
        {
            Information information = new Information();
            Console.WriteLine("Please enter your name: ");
            information.Name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            information.Address = Console.ReadLine();
            Console.WriteLine("Please enter your phone: ");
            information.Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Information just entered:");
            Console.WriteLine($"Name: {information.Name}, Address: {information.Address}, Phone: {information.Phone}");
        }
    }
}