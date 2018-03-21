using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.CommandHandler;


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
    }
}
