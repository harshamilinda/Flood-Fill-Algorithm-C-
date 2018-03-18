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
                CommandText = Console.ReadLine();
                Client.InvokeCommand(CommandText);
            }
        }
    }
}
