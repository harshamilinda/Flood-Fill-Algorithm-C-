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
        public int X { get; set; }
        public int Y { get; set; }
        public char FillColour { get; set; }

        public T Fill<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            //B 10 3 o
            Canvas = canvas;
            FillColour = char.Parse(instructions[ConsoleCommand.Colour]);
            var Positions = instructions.GetPositions();
            X = Positions[Axis.X1];
            Y = Positions[Axis.Y1];
            var DataPoint = new DataPoint { X = X, Y = Y };
            Octa(DataPoint);



            return canvas;
        }

        private void ProcessDataPoint(int x, int y, Stack<DataPoint> dataPoints)
        {
            // Validate data range
            if (Canvas.Count > y && Canvas.FirstOrDefault().Line.Length > x)
            {
                if (char.IsWhiteSpace(Canvas[y].Line[x]))
                {
                    Canvas[y].Line[x] = FillColour;
                    dataPoints.Push(new DataPoint { X = x, Y = y });
                }

            }




        }
        private void Octa(DataPoint d)
        {
            var Items = new Stack<DataPoint>();
            // is empty
            if (char.IsWhiteSpace(Canvas[d.Y].Line[d.X]))
                //fill - only for the fist time
                Canvas[d.Y].Line[d.X] = FillColour;
            //do not add

            //is top
            //if (char.IsWhiteSpace(Canvas[d.Y - 1].Line[d.X]))
                ProcessDataPoint(d.X, d.Y - 1, Items);

            //is topleft
            //if (char.IsWhiteSpace(Canvas[d.Y - 1].Line[d.X - 1]))
                ProcessDataPoint(d.X-1, d.Y - 1, Items);
            //Fill
            //Add


            //is topright
            //if (char.IsWhiteSpace(Canvas[d.Y - 1].Line[d.X + 1]))
                ProcessDataPoint(d.X+1, d.Y - 1, Items);


            //previous
            //if (char.IsWhiteSpace(Canvas[d.Y].Line[d.X - 1]))
                ProcessDataPoint(d.X-1, d.Y, Items);


            //next
            //if (char.IsWhiteSpace(Canvas[d.Y].Line[d.X + 1]))
                ProcessDataPoint(d.X + 1, d.Y, Items);

            //down
            //if (char.IsWhiteSpace(Canvas[d.Y + 1].Line[d.X]))
                ProcessDataPoint(d.X, d.Y + 1, Items);


            //downLeft
            //if (char.IsWhiteSpace(Canvas[d.Y + 1].Line[d.X - 1]))
                ProcessDataPoint(d.X - 1, d.Y + 1, Items);


            //downright
            //if (char.IsWhiteSpace(Canvas[d.Y + 1].Line[d.X + 1]))
                ProcessDataPoint(d.X + 1, d.Y + 1, Items);




            //add to datapoint array

            //Not return 8 all the time
            while(Items.Count >0)
            {
                Octa(Items.Pop());
            }
           
        }

    }
}
