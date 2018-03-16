using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.BusinessLogic;

namespace CreditSuisse.Tech
{
    class Program
    {
        static void Main(string[] args)
        {
            new Class1().PrintCanvas();
            new Line().DrawLine(new string[]{ "C 20 4", "L 1 2 6 2" });
            new Line().DrawLine(new string[] { "C 20 4", "L 1 3 6 3" });

            //new Rectangle().DrawRectangle(new string[] { "C 20 4", "R 14 1 18 3" });

            //R 14 1 18 3

            Console.Read();

        }
    }
}
