using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.CommandHandler
{
    public interface IReceiver
    {
        void Action(Dictionary<ConsoleCommand, string> instructions);
    }
}
