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

        public void ExecuteCommand()
        {
            //Command.Execute();
        }
        

    }
}
