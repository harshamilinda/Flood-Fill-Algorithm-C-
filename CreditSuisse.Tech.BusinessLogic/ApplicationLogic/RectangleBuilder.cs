using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class RectangleBuilder : IGeometry
    {
        public T BuildGeometry<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            HorizontalPrint(canvas, instructions);
            VerticalPrint(canvas, instructions);
            return canvas;
        }

        private T HorizontalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Positions = instructions.GetPositions();
            var Length = (Positions[Axis.X2] - Positions[Axis.X1]) + 1;
           
            canvas[Positions[Axis.Y1]].Line.Replace(Constants.CHARWHITESPACE, Constants.LINECOLOUR, Positions[Axis.X1], Length);
            canvas[Positions[Axis.Y2]].Line.Replace(Constants.CHARWHITESPACE, Constants.LINECOLOUR, Positions[Axis.X1], Length);

            return canvas;
        }
        private T VerticalPrint<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            var Positions = instructions.GetPositions();
            var Index = Positions[Axis.Y2] - Positions[Axis.Y1];
            var Length = 1;

            canvas[Index].Line.Replace(Constants.CHARWHITESPACE, Constants.LINECOLOUR, Positions[Axis.X1], Length);
            canvas[Index].Line.Replace(Constants.CHARWHITESPACE, Constants.LINECOLOUR, Positions[Axis.X2], Length);


            return canvas;
        }
        
    }
}
