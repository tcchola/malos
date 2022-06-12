using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1
{
    class Apps
    {
        public void Calculator()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Calculator App -");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Input First Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second Number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Operation (+, -, *, /, %): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(n1 + n2);
                    break;
                case "-":
                    Console.WriteLine(n1 - n2);
                    break;
                case "*":
                    Console.WriteLine(n1 * n2);
                    break;
                case "/":
                    Console.WriteLine(n1 / n2);
                    break;
                case "%":
                    Console.WriteLine(n1 % n2);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        public void Clock()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
