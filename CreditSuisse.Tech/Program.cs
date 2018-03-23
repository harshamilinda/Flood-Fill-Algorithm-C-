using System;


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
