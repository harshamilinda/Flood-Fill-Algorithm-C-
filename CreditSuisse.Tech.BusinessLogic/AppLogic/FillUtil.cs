using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic.AppLogic
{
    public class FillUtil
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




            return canvas;
        }
        private void Current(int x, int y)
        {
            if (Char.IsWhiteSpace(Canvas[y].Line[x])) Canvas[y].Line[x] = FillColour;
            Backward(x, y);
            Forward(x, y);
        }
        private void Backward(int x, int y)
        {
            if (x-- > 0) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line[x] = FillColour; x--;
                Backward(x, y);
            }
        }
        private void Forward(int x, int y)
        {
            if (x++ < Canvas[y].Line.Length) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line[x] = FillColour; x++;
                Forward(x, y);
            }
        }
        private void Up(int x, int y)
        {
            while (y >0)
            {
                UpNext(x, y);
                UpPrevious(x, y);
                y--;
            }

        }
        private void UpPrevious(int x, int y)
        {
            if (x-- > 0 || y-- > 0) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y - 1].Line[x].Equals(FillColour) || Canvas[y - 1].Line[x + 1].Equals(FillColour)))
            {
                Canvas[y].Line[x] = FillColour; x--;
                UpPrevious(x, y);
            }
        }
        private void UpNext(int x, int y)
        {
            if (x++ < Canvas[Y].Line.Length || y-- > 0) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y - 1].Line[x].Equals(FillColour) || Canvas[y - 1].Line[x - 1].Equals(FillColour)))
            {
                Canvas[y].Line[x] = FillColour; x++;
                UpNext(x, y);
            }
        }
        private void Down(int x, int y)
        {
            while(y< Canvas.Count)
            {
                DownNext(x, y);
                DownPrevious(x, y);
                y++;
            }
           
        }
        private void DownPrevious(int x, int y)
        {
            if (x-- > 0 || y++ < Canvas.Count) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y + 1].Line[x].Equals(FillColour) || Canvas[y + 1].Line[x + 1].Equals(FillColour)))
            {
                Canvas[y].Line[x] = FillColour; x--;
                DownPrevious(x, y);
            }
        }
        private void DownNext(int x, int y)
        {
            if (x++ < Canvas[Y].Line.Length || y++ < Canvas.Count) return;
            if (Char.IsWhiteSpace(Canvas[y].Line[x]) && (Canvas[y + 1].Line[x].Equals(FillColour) || Canvas[y + 1].Line[x - 1].Equals(FillColour)))
            {
                Canvas[y].Line[x] = FillColour; x++;
                DownNext(x, y);
            }
        }
    }
}
