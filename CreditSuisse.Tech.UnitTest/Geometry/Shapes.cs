using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditSuisse.Tech.Entities;
using CreditSuisse.Tech.BusinessLogic;
using CreditSuisse.Tech.CommandHandler;

namespace CreditSuisse.Tech.UnitTest.Geometry
{
    [TestClass]
    public class Shapes 
    {
        
        public List<DataLine> Canvas { get; set; }
        public Shapes()
        {
            GetCanvas();
        }

        [TestMethod]
        public void DrawHorizontalLine()
        {

            var Instructions = new Dictionary<ConsoleCommand, string> {
                {ConsoleCommand.ObjectType,"L" },
                {ConsoleCommand.X1,"1" },
                {ConsoleCommand.Y1,"2" },
                {ConsoleCommand.X2,"6" },
                {ConsoleCommand.Y2,"2" }
            };
            List<DataLine> Actual = new LineBuilder().BuildGeometry(Canvas, Instructions);

            List<DataLine> Expected = new List<DataLine> {
                
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|xxxxxx            |")},
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) }

            };
            Expected.ForEach(x => Assert.AreEqual(x.Line.ToString(), Actual[Expected.IndexOf(x)].Line.ToString()));
        }
        [TestMethod]
        public void DrawVerticallLine()
        {

            var Instructions = new Dictionary<ConsoleCommand, string> {
                {ConsoleCommand.ObjectType,"L" },
                {ConsoleCommand.X1,"6" },
                {ConsoleCommand.Y1,"3" },
                {ConsoleCommand.X2,"6" },
                {ConsoleCommand.Y2,"4" }
            };
            List<DataLine> Actual = new LineBuilder().BuildGeometry(Canvas, Instructions);

            List<DataLine> Expected = new List<DataLine> {

                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|xxxxxx            |")},
                new DataLine{ Line= new StringBuilder().Insert(0, "|     x            |")},
                new DataLine{ Line= new StringBuilder().Insert(0, "|     x            |")},
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) }

            };
            Expected.ForEach(x => Assert.AreEqual(x.Line.ToString(), Actual[Expected.IndexOf(x)].Line.ToString()));
        }

        private void GetCanvas()
        {
            var Instructions = new Dictionary<ConsoleCommand, string> {
                {ConsoleCommand.ObjectType,"C" },
                {ConsoleCommand.X1,"20" },
                {ConsoleCommand.Y1,"4" }
            };
            Canvas = CanvasBuilder.GetCanvas<List<DataLine>>(Instructions);
        }
    }
}
