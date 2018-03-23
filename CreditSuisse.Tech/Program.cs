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
            Client.PrintHeader();
            Client.PrintHelpMenu();

            Boolean IsRunning = true;
            while (IsRunning)
            {
                Client.InvokeCommand(Console.ReadLine());
            }
            Console.Read();
        }
        
        
        
    }
}
