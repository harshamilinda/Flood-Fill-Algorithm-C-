using System;
using System.Collections.Generic;
using System.Linq;
using CreditSuisse.Tech.BusinessLogic;
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
            if (String.IsNullOrWhiteSpace(commandText)) return false;
            return true;
        }

        private string[] FormatCommandText(string commandText) => commandText.Split(' ');

        private T InitializeCommand<T>(string[] commandText) where T : Dictionary<ConsoleCommand, string>, new()
        {
            Dictionary<ConsoleCommand, string> Instructions = new Dictionary<ConsoleCommand, string>();
            try
            {
               
                var Commands = Enum.GetValues(typeof(ConsoleCommand)).Cast<ConsoleCommand>().GetEnumerator();
                var Values = commandText.GetEnumerator();
                while (Commands.MoveNext() && Values.MoveNext())
                {
                    Instructions.Add(Commands.Current, Values.Current.ToString());
                }
                if (commandText[commandText.Length - 1].IsFillCommand()) Instructions.Add(ConsoleCommand.Colour, commandText[commandText.Length - 1]);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return (T)Instructions;

        }
        
    }
}
