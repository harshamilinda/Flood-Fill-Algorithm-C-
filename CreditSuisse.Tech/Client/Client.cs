using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                new Invoker().ExecuteCommand(commandText);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            
        }
        public void PrintHeader() => Console.WriteLine(Constants.ConsoleHeader);
        public void PrintHelpMenu() => Console.WriteLine(Constants.HelpMenu);
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
