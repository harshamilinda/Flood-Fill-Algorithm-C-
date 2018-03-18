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
            if(instructions[ConsoleCommand.Y1]==instructions[ConsoleCommand.Y2]) HorizontalPrint(canvas, instructions); 
            else VerticalPrint(canvas, instructions); 
            return canvas;
        }

        private T HorizontalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Positions = instructions.GetPositions();
            canvas[Positions[Axis.Y1]].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, Positions[Axis.X1], Positions[Axis.X2]);
            return canvas;
        }

        private T VerticalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Positions = instructions.GetPositions();
            while (Positions[Axis.Y1] <= Positions[Axis.Y2])
            {
                canvas[Positions[Axis.Y1]].Line.Replace(Constants.CharWhiteSpace, Constants.LineColour, Positions[Axis.X1], 1);
                Positions[Axis.Y1]++;
            }
            return canvas;
        }



       

    }
}
