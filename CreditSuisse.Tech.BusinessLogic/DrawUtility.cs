using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class DrawUtility : IDrawable
    {
        public void Draw<T>(T listOfEntities) where T : List<DataLine>, new()
        {
            listOfEntities.ForEach(item => Console.WriteLine(item.Line));
            Console.Read();
        }

        public char[] FormatCommandText(string commandText)
        {
            commandText.Replace(" ", string.Empty);
            return commandText.ToCharArray();
        }

        public bool ValidateDrawCommand(string commandText)
        {
            //TODO: add proper validations
            if (String.IsNullOrWhiteSpace(commandText))return false;
            return true;
        }
    }
}
