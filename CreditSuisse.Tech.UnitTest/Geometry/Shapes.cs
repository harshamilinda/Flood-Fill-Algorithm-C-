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
    public class Shapes : Shape
    {
        public Shapes()
        {
        }

        [TestMethod]
        public void DrawLine()
        {
            // new Invoker().ExecuteCommand("C 20 4");
            var Instructions = new Dictionary<ConsoleCommand, string> {
                {ConsoleCommand.ObjectType,"C" },
                {ConsoleCommand.X1,"10" },
                {ConsoleCommand.Y1,"2" }
            };

            var Actual = CanvasBuilder.GetCanvas<List<DataLine>>(Instructions);
            List<DataLine> Expected = new List<DataLine> {

                new DataLine{ Line= new StringBuilder().Insert(0, "-", 10) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 10) },

            };


            Assert.AreEqual(Expected[0].Line[0], Actual[0].Line[0]);
            Assert.AreEqual(Expected[0].Line[1], Actual[0].Line[1]);
            Assert.AreEqual(Expected[0].Line[2], Actual[0].Line[2]);
            Assert.AreEqual(Expected[0].Line[3], Actual[0].Line[3]);




        }
    }
}
