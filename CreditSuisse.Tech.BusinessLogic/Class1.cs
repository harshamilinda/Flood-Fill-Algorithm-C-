using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class DataLine
    {
        public StringBuilder Line { get; set; }
    }
    public class Class1
    {
        public List<DataLine> Canvas { get; set; }
        public void Test()
        {
            int[] PositionsX, PositionsY;
            PositionsX = new int[] { 1, 2, 3, 4 };
            PositionsY = new int[] { 1, 2, 3, 4 };

            List<Rectangle> Shapes = new List<Rectangle> {
                    new Rectangle{},
                    new Rectangle{}
            };


            List<DataLine> Canvas = new List<DataLine> {

                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },



            };






        }

        public void PrintCanvas()
        {
            Canvas = new List<DataLine> {

                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },



            };

            Console.WriteLine("Print items");
            // L 1 2 6 2
            // horizontal 
            Canvas[2].Line.Replace(' ', 'x', 1, 6);

            // L 6 3 6 4
            // vertical
            Canvas[3].Line.Replace(' ', 'x', 6, 1);
            Canvas[4].Line.Replace(' ', 'x', 6, 1);


            //Print Rectangle
            //R 14 1 18 3
            Canvas[1].Line.Replace(' ', 'x', 13, 5);
            Canvas[3].Line.Replace(' ', 'x', 13, 5);


            Canvas[2].Line.Replace(' ', 'x', 13, 1);
            Canvas[2].Line.Replace(' ', 'x', 17, 1);


            //Fill Current - UP
            LinearFill(10, 3);
            LinearFill(10, 2);
            LinearFill(10, 1);

            //Fill Current - Down
            LinearFill(10, 4);

            foreach (var item in Canvas)
            {
                Console.WriteLine(item.Line);
            }





            Console.Read();

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
        public bool Backword(int x, int y)
        {
            //Flood Fill
            if (Char.IsWhiteSpace(Canvas[y].Line[x]))
            {
                Canvas[y].Line.Replace(' ', 'o', x, 1);
                x++;
                if (x != 19) return Backword(x, y);
            }
            return true;
        }

        public void LinearFill(int x, int y)
        {
            int Next = x + 1;
            Forward(x, y);
            Backword(Next, y);

        }


    }

}

