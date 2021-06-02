using System;
using System.Text;

namespace Bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            InformationController informationController = new InformationController();
            InformationController.Information();
        }
    }
}