using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;


namespace CreditSuisse.Tech.BusinessLogic
{
    public class FillUtility : IFillable
    {
        public List<DataLine> Canvas { get; set; }
        public char FillColour { get; set; }

        public T Fill<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            Canvas = canvas;
            FillColour = char.Parse(instructions[ConsoleCommand.Colour]);
            var Positions = instructions.GetPositions();
            var DataPoint = new DataPoint { X = Positions[Axis.X1], Y = Positions[Axis.Y1] };
            if (IsValidDataPoint(DataPoint))
                FloodFill(DataPoint);

            return canvas;
        }
        private bool IsValidDataPoint(DataPoint d) => (char.IsWhiteSpace(Canvas[d.Y].Line[d.X]));

        private void ProcessDataPoint(int x, int y, Stack<DataPoint> dataPoints)
        {
            if (Canvas.Count > y && Canvas.FirstOrDefault().Line.Length > x)
            {
                if (char.IsWhiteSpace(Canvas[y].Line[x]))
                {
                    Canvas[y].Line[x] = FillColour;
                    dataPoints.Push(new DataPoint { X = x, Y = y });
                }
            }
        }
        /// <summary>
        /// Flood Fill
        /// </summary>
        /// <param name="d">DataPoint</param>
        private void FloodFill(DataPoint d)
        {
            var Items = new Stack<DataPoint>();
            if (char.IsWhiteSpace(Canvas[d.Y].Line[d.X]))
                Canvas[d.Y].Line[d.X] = FillColour;
            
            //Top
            ProcessDataPoint(d.X, d.Y - 1, Items);
            //Top Left
            ProcessDataPoint(d.X - 1, d.Y - 1, Items);
            //Top Right
            ProcessDataPoint(d.X + 1, d.Y - 1, Items);
            //Previous
            ProcessDataPoint(d.X - 1, d.Y, Items);
            //Next
            ProcessDataPoint(d.X + 1, d.Y, Items);
            //Down
            ProcessDataPoint(d.X, d.Y + 1, Items);
            //Down Left
            ProcessDataPoint(d.X - 1, d.Y + 1, Items);
            //Down Right
            ProcessDataPoint(d.X + 1, d.Y + 1, Items);

            while (Items.Count > 0)
            {
                FloodFill(Items.Pop());
            }
        }

    }
}
