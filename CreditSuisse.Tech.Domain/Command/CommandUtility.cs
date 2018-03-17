using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.CommandHandler
{
    public class CommandUtility
    {
        public CommandUtility(){}
        public Dictionary<ConsoleCommand, string> GetInstructions(string commandText)
        {
            if (ValidateDrawCommand(commandText))
            {
                var command = FormatCommandText(commandText);
                return InitializeCommand<Dictionary<ConsoleCommand, string>>(command);
            }
            return null;
        }

        private bool ValidateDrawCommand(string commandText)
        {
            //TODO: add proper validations
            //X1,X2,Y1,Y2 - int , cannot < 0,  x1 shoud < x1, y1 should <y2
            if (String.IsNullOrWhiteSpace(commandText)) return false;
            return true;
        }

        private string[] FormatCommandText(string commandText) => commandText.Split(' ');

        private T InitializeCommand<T>(string[] commandText) where T : Dictionary<ConsoleCommand, string>, new()
        {
            Dictionary<ConsoleCommand, string> Instructions = new Dictionary<ConsoleCommand, string>();
            var Commands = Enum.GetValues(typeof(ConsoleCommand)).Cast<ConsoleCommand>().GetEnumerator();
            var Values = commandText.GetEnumerator();
            while (Commands.MoveNext() && Values.MoveNext())
            {
                Instructions.Add(Commands.Current, Values.Current.ToString());
            }
            return (T)Instructions;

        }
    }
}
