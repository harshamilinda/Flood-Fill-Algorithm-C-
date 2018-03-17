using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.CommandHandler
{
    public class Invoker
    {
        public ICommand Command { get; set; }
        public Invoker() => Command = new CommandBuilder();
        public void ExecuteCommand(string commandText)
        {
            Command.Execute(commandText);
        }
        

    }
}
