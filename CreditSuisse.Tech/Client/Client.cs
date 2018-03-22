using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.CommandHandler;

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
    }
}
