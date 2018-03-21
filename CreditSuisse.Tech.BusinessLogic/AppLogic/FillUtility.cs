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
            Canvas = canvas;
            FillColour = char.Parse(instructions[ConsoleCommand.Colour]);
            var Positions = instructions.GetPositions();
            X = Positions[Axis.X1];
            Y = Positions[Axis.Y1];
            var Length = (Positions[Axis.X1] - Positions[Axis.Y1]) + 1;

            //Fill Current - UP
            LinearFill(10, 3);
            LinearFill(10, 2);
            LinearFill(10, 1);

            //Fill Current - Down
            LinearFill(10, 4);

            //Vertical Fill
            VerticalFill(0, 0, 'o');
            return canvas;
        }

        public bool Forward(int x, int y)
        {
            //Flood Fill
            //B 10 3 o

            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line.Replace(' ', 'o', x, 1);
                x--;
                if (x != 0) return Forward(x, y);
            }
            return true;
        }
        public bool Backward(int x, int y)
        {
            //Flood Fill
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line.Replace(' ', 'o', x, 1);
                x++;
                if (x != 19) return Backward(x, y);
            }
            return true;
        }

        public void LinearFill(int x, int y)
        {
            int Next = x + 1;
            Forward(x, y);
            Backward(Next, y);

        }
        public int VerticalFill(int x, int y, char color)
        {
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y + 1].Line[x].Equals(color) || y != 0 && Canvas[y - 1].Line[x].Equals(color)))
            {
                Canvas[y].Line[x] = color;
                y = 0;
                VerticalFill(x, y, color);
            }
            else if (y < Canvas.Count - 1)
            {
                y++;
                return VerticalFill(x, y, color);
            }
            else if (x < Canvas[y].Line.Length - 1)
            {
                x++;
                y = 0;
                return VerticalFill(x, y, color);
            }
            return 0;

        }

    }
}
