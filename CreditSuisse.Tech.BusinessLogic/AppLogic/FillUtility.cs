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


            Current();
            Up(X, Y - 1);
            Down(X, Y + 1);



            return canvas;
        }
        private void Current()
        {
            if (Char.IsWhiteSpace(Canvas[Y].Line[X])) Canvas[Y].Line[X] = FillColour;
            Backward(X - 1, Y);
            Forward(X + 1, Y);
        }
        private void Backward(int x, int y)
        {
            if (!(x > 0)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line[x] = FillColour;
                x--;
                Backward(x, y);
            }
        }
        private void Forward(int x, int y)
        {
            if (!(x < Canvas[y].Line.Length)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line[x] = FillColour;
                x++;
                Forward(x, y);
            }
        }
        private void Up(int x, int y)
        {
            while (y > 0)
            {
                UpNext(x, y);
                UpPrevious(x, y);
                y--;
            }

        }
        private void UpPrevious(int x, int y)
        {
            if (!(x-- > 0 || y-- > 0)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y - 1].Line[x].Equals(FillColour) || Canvas[y - 1].Line[x + 1].Equals(FillColour)))
            {
                Canvas[y].Line.Replace(Constants.CharWhiteSpace, FillColour, x, 1);
                x--;
                UpPrevious(x, y);
            }
        }
        private void UpNext(int x, int y)
        {
            if (!(x++ < Canvas[Y].Line.Length || y-- > 0)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y - 1].Line[x].Equals(FillColour) || Canvas[y - 1].Line[x - 1].Equals(FillColour)))
            {
                Canvas[y].Line.Replace(Constants.CharWhiteSpace, FillColour, x, 1);
                x++;
                UpNext(x, y);
            }
        }
        private void Down(int x, int y)
        {
            while (y < Canvas.Count)
            {
                DownNext(x, y);
                DownPrevious(x, y);
                y++;
            }

        }
        private void DownPrevious(int x, int y)
        {
            if (!(x-- > 0 || y++ < Canvas.Count)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y + 1].Line[x].Equals(FillColour) || Canvas[y + 1].Line[x + 1].Equals(FillColour)))
            {
                Canvas[y].Line.Replace(Constants.CharWhiteSpace, FillColour, x, 1); x--;
                DownPrevious(x, y);
            }
        }
        private void DownNext(int x, int y)
        {
            if (!(x++ < Canvas[Y].Line.Length || y++ < Canvas.Count)) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y + 1].Line[x].Equals(FillColour) || Canvas[y + 1].Line[x - 1].Equals(FillColour)))
            {
                Canvas[y].Line.Replace(Constants.CharWhiteSpace, FillColour, x, 1); x++;
                DownNext(x, y);
            }
        }

    }
}
