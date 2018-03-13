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
            List<DataLine> Canvas = new List<DataLine> {

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
            Canvas[3].Line.Replace(' ', 'x', 6,1);
            Canvas[4].Line.Replace(' ', 'x', 6, 1);


            //Print Rectangle
            //R 14 1 18 3
            Canvas[1].Line.Replace(' ', 'x', 14, 5);
            Canvas[3].Line.Replace(' ', 'x', 14, 5);


            Canvas[2].Line.Replace(' ', 'x', 14, 1);
            Canvas[2].Line.Replace(' ', 'x', 18, 1);


            foreach (var item in Canvas)
            {
                Console.WriteLine(item.Line);
            }
            
                





            //Console.Write(CanvasBuilder.ToString());
            Console.Read();






        }
    }
}
