using System;
using CreditSuisse.Tech.CommandHandler;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech
{
    public class Client
    {
        public void InvokeCommand(string commandText)
        {
            try
            {
                if (commandText.ToUpper().Equals("Q")) Environment.Exit(0);
                new Invoker().ExecuteCommand(commandText);
            }
            catch
            {
                Console.WriteLine("The command is invalid. Please follow the instructions.");
                Console.WriteLine(Constants.HelpMenu);
            }
            finally
            {

            }
            
        }
        public void PrintHeader() => Console.WriteLine(Constants.CONSOLEHEADER);
        public void PrintHelpMenu() => Console.WriteLine(Constants.HelpMenu);
        private void Undo()
        {
            //TODO: Implement Undo Command
        }
        private void Reset()
        {
            //TODO: Implement Reset Command
        }
    }
}
