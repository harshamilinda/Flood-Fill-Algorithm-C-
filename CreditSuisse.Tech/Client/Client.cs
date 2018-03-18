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
            new Invoker().ExecuteCommand(commandText);
            
        }
    }
}
