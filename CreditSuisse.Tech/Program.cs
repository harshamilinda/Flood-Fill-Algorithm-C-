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
                CommandText = Console.ReadLine();
                Client.InvokeCommand(CommandText);

            }
            Console.Read();
        }
        private void PrintHelpMenu()
        {
            //TODO: Print Help Menu
        }
        private void Undo()
        {
            //TODO: Implement Undo Command
        }
        private void Reset()
        {
            //TODO: IMplement Reset Command
        }
        
        
    }
}
