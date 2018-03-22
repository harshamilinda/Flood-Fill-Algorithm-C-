using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CreditSuisse.Tech.CommandHandler;
using CreditSuisse.Tech.Entities;


namespace CreditSuisse.Tech
{
    class Program
    {
        static void Main(string[] args)
        {
            var Client = new Client();
            string CommandText = string.Empty;

            Boolean IsRunning = true;
            while (IsRunning)
            {
                //CommandText = Console.ReadLine();
                //Client.InvokeCommand(CommandText);


                //TEST
                Client.InvokeCommand("C 20 4");
                Client.InvokeCommand("L 6 3 6 4");
                Client.InvokeCommand("L 1 2 6 2");
                Client.InvokeCommand("R 14 1 18 3");
                Client.InvokeCommand("B 10 3 o");
                //Client.InvokeCommand("B 13 3 o");
                IsRunning = false;
            }
            Console.Read();
        }
        //public void Test()
        //{
        //    var Instructions = new Dictionary<ConsoleCommand, string> {
        //        {ConsoleCommand.ObjectType,"C" },
        //        {ConsoleCommand.X1,"20" },
        //        {ConsoleCommand.Y1,"4" }
        //    };

        //    List<DataLine> Canvas = CanvasBuilder.GetCanvas<List<DataLine>>(Instructions);
        //    List<DataLine> Expected = new List<DataLine> {

        //        new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },

        //    };
        //}
    }
}
