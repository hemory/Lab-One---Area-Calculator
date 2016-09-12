using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop
            string toContinue;
            do
            {
                Console.WriteLine("Please enter a length.");
                string inputLength = Console.ReadLine(); 

                Console.WriteLine("Please enter a width.");
                string inputWidth = Console.ReadLine();

                decimal length = decimal.Parse(inputLength);
                decimal width = decimal.Parse(inputWidth);

                decimal area = length * width;
                decimal perimeter = 2 * (length + width);

                Console.WriteLine("The Area would be : " + area);
                Console.WriteLine("The Perimeterwould be : " + perimeter);

                Console.WriteLine("Continue? y/n");
                toContinue = Console.ReadLine();
            } while (toContinue == "y");
        }
    }
}
