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
        public List<DataLine> Canvas  { get; set; }
        public Dictionary<Axis,int> Positions { get; set; }
        public char FillColour { get; set; }
        public T Fill<T>(T canvas, Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            Canvas = canvas;
            FillColour = char.Parse(instructions[ConsoleCommand.Colour]);
            Positions = instructions.GetPositions();
            var Length = (Positions[Axis.X1] - Positions[Axis.Y1]) + 1;
            
            LinearFill();
            VerticalFill();
            return canvas;
        }

        private void LinearFill()
        {
            int Next = Positions[Axis.X1] + 1;
            Forward(Positions[Axis.X1], Positions[Axis.Y1]);
            Backward(Next, Positions[Axis.Y1]);

        }
        private bool Forward(int x, int y)
        {
            //Flood Fill
            //B 10 3 o
            Canvas[Positions[Axis.Y1]].Line.Replace(Constants.CharWhiteSpace,FillColour, Positions[Axis.X1], 1);
            Positions[Axis.X1]--;
            if (Positions[Axis.X1] != 0) return Forward(Positions[Axis.X1], Positions[Axis.Y1]);
            return true;
        }
        public bool Backward(int x, int y)
        {
            Canvas[Positions[Axis.Y1]].Line.Replace(Constants.CharWhiteSpace, FillColour, Positions[Axis.X1], 1);
            Positions[Axis.X1]++;
            if (Positions[Axis.X1] != 19) return Backward(Positions[Axis.X1], Positions[Axis.Y1]);
            return true;
        }

       
        public int VerticalFill()
        {
            if (Char.IsWhiteSpace(Canvas[Positions[Axis.Y1]].Line[Positions[Axis.X1]]) 
                && (Canvas[Positions[Axis.Y1] + 1].Line[Positions[Axis.X1]].Equals(FillColour) 
                || Positions[Axis.Y1] != 0 && Canvas[Positions[Axis.Y1] - 1].Line[Positions[Axis.X1]].Equals(FillColour)))
            {
                Canvas[Positions[Axis.Y1]].Line[Positions[Axis.X1]] = FillColour;
                Positions[Axis.Y1] = 0; //reset
                VerticalFill();
            }
            else if (Positions[Axis.Y1] < Canvas.Count - 1)
            {
                Positions[Axis.Y1]++;
                return VerticalFill();
            }
            else if (Positions[Axis.X1] < Canvas[Positions[Axis.Y1]].Line.Length - 1)
            {
                Positions[Axis.X1]++;
                Positions[Axis.Y1] = 0; //reset
                return VerticalFill();
            }
            return 0;

        }
    }
}
