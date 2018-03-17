using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.CommandHandler
{
    class CommandBuilder : ICommand
    {
        private Dictionary<ActionType, IReceiver> CommandContext { get; set; }

        public CommandBuilder()
        {
            CommandContext = new Dictionary<ActionType, IReceiver>
            {
               {ActionType.C, new CanvasReceiver()},
               {ActionType.L,new LineReceiver()},
               {ActionType.R,new RectangleReceiver()},
            };

        }
        public void Execute(string commandText)
        {
            var Instructions = new CommandUtility().GetInstructions(commandText);
            var Action = (ActionType)System.Enum.Parse(typeof(ActionType), Instructions[ConsoleCommand.ObjectType].ToString());
            CommandContext[Action].Action(Instructions);

        }





    }
}
