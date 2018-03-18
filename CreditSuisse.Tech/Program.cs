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
            String CommandText = string.Empty;
            //Client.InvokeCommand(Console.ReadLine());

            Boolean IsRunning = true;
            while (IsRunning)
            {
                CommandText = Console.ReadLine();
                Console.WriteLine(CommandText);
                Client.InvokeCommand(CommandText);
            }


        }
    }
}
