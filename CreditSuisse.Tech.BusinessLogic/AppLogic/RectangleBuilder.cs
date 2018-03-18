using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    class RectangleBuilder : IGeometry
    {
        public T BuildGeometry<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            HorizontalPrint(canvas, instructions);
            VerticalPrint(canvas, instructions);
            return canvas;
        }

        private T HorizontalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var X1 = int.Parse(instructions[ConsoleCommand.X1]);
            var X2 = int.Parse(instructions[ConsoleCommand.X2]);
            var Y1 = int.Parse(instructions[ConsoleCommand.Y1]);
            var Y2 = int.Parse(instructions[ConsoleCommand.Y2]);
            var Length = (X2 - X1)+1;

            X1--;
            canvas[Y1].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, Length);
            canvas[Y2].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, Length);

            return canvas;
        }
        private T VerticalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var X1 = int.Parse(instructions[ConsoleCommand.X1]);
            var X2 = int.Parse(instructions[ConsoleCommand.X2]);
            var Y1 = int.Parse(instructions[ConsoleCommand.Y1]);
            var Y2 = int.Parse(instructions[ConsoleCommand.Y2]);
            var Length = 1;
            var Index = Y2 - Y1;
            X1--;
            X2--;
          
                canvas[Index].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, Length);
                canvas[Index].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X2, Length);
              
            
            return canvas;
        }
    }
}
