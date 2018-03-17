using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.CommandHandler
{
    public interface ICommand
    {
        void Execute(string commandText);
    }
}
