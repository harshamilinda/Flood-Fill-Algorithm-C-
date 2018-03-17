using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    class LineBuilder : IGeometry
    {
        public T BuildGeometry<T>(T canvas, Dictionary<ConsoleCommand, string> instructions ) where T : List<DataLine>, new()
        {
            if(instructions[ConsoleCommand.Y1]==instructions[ConsoleCommand.Y2]) 
                HorizontalPrint(canvas, instructions); // L 1 2 6 2
            else
               VerticalPrint(canvas, instructions); // L 6 3 6 4
            return canvas;
        }
        private T HorizontalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Index = int.Parse(instructions[ConsoleCommand.Y1].ToString());
            canvas[Index].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, 
                                    int.Parse(instructions[ConsoleCommand.X1].ToString()),
                                    int.Parse(instructions[ConsoleCommand.X2].ToString()));
            return canvas;
        }

        private T VerticalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Y1 = int.Parse(instructions[ConsoleCommand.Y1].ToString());
            var Y2 = int.Parse(instructions[ConsoleCommand.Y2].ToString());
            
            while (Y1 <= Y2)
            {
                canvas[Y1].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, Y2, 1);
                Y1++;
            }
            return canvas;
        }



       

    }
}
