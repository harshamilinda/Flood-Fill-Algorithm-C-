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
        public T BuildGeometry<T>(T canvas, Dictionary<ConsoleCommand, char> instructions) where T : List<DataLine>, new()
        {
            HorizontalPrint(canvas, instructions);
            VerticalPrint(canvas, instructions);
            return canvas;

        }
        private T HorizontalPrint<T>(T canvas, Dictionary<ConsoleCommand, char> instructions) where T : List<DataLine>, new()
        {
            var X1 = int.Parse(instructions[ConsoleCommand.X1].ToString()) ;
            var Y1 = int.Parse(instructions[ConsoleCommand.Y1].ToString());
            var Y2 = int.Parse(instructions[ConsoleCommand.Y2].ToString());
            var Length = (Y1 - Y2) + 1;

            canvas[Y1].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, Length);
            canvas[Y2].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, Length);

            return canvas;
        }
        private T VerticalPrint<T>(T canvas, Dictionary<ConsoleCommand, char> instructions) where T : List<DataLine>, new()
        {
            var X1 = int.Parse(instructions[ConsoleCommand.X1].ToString()) ;
            var X2 = int.Parse(instructions[ConsoleCommand.X2].ToString()) ;
            var Y1 = int.Parse(instructions[ConsoleCommand.Y1].ToString());
            var Y2 = int.Parse(instructions[ConsoleCommand.Y2].ToString());

            while (Y1 <= Y2)
            {
                canvas[Y1].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X1, 1);
                canvas[Y1].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, X2, 1);
                Y1++;
            }
            return canvas;
        }
    }
}
