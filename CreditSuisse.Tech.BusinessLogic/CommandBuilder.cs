using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    class CommandBuilder : ICommand
    {
        public Dictionary<ConsoleCommand, char> GetInstructions(string commandText)
        {
            if(ValidateDrawCommand(commandText))
            {
                var command = FormatCommandText(commandText);
                return InitializeCommand < Dictionary<ConsoleCommand, char>> (command);
            }
            return null;
        }

        private T InitializeCommand<T>(char[] commandText) where T : Dictionary<ConsoleCommand, char>, new()
        {
            Dictionary<ConsoleCommand, char> Instructions = new Dictionary<ConsoleCommand, char>();
            var Commands = Enum.GetValues(typeof(ConsoleCommand)).Cast<ConsoleCommand>().GetEnumerator();
            var Values = commandText.GetEnumerator();

            while (Commands.MoveNext() && Values.MoveNext())
            {
                Instructions.Add(Commands.Current, char.Parse(Values.Current.ToString()));
            }
            return (T)Instructions;

        }
        private char[] FormatCommandText(string commandText)
        {
            commandText.Replace(" ", string.Empty);
            return commandText.ToCharArray();
        }

        private bool ValidateDrawCommand(string commandText)
        {
            //TODO: add proper validations
            if (String.IsNullOrWhiteSpace(commandText)) return false;
            return true;
        }



    }
}
