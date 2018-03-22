using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditSuisse.Tech.Entities;
using CreditSuisse.Tech.BusinessLogic;
using CreditSuisse.Tech.CommandHandler;

namespace CreditSuisse.Tech.UnitTest
{
    [TestClass]
    public class Canvas
    {
        [TestMethod]
        public void GetCanvas()
        {
            var Instructions = new Dictionary<ConsoleCommand, string> {
                {ConsoleCommand.ObjectType,"C" },
                {ConsoleCommand.X1,"20" },
                {ConsoleCommand.Y1,"4" }
            };

            List<DataLine> Actual = CanvasBuilder.GetCanvas<List<DataLine>>(Instructions);
            
            List<DataLine> Expected = new List<DataLine>() {

                new DataLine(){ Line= new StringBuilder().Insert(0, "-", 22) },
                new DataLine(){ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",20).Insert(21,"|") },
                new DataLine(){ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",20).Insert(21,"|") },
                new DataLine(){ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",20).Insert(21,"|") },
                new DataLine(){ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",20).Insert(21,"|") },
                new DataLine(){ Line= new StringBuilder().Insert(0, "-", 22) },

            };

            Expected.ForEach(x => Assert.AreEqual(x.Line.ToString(), Actual[Expected.IndexOf(x)].Line.ToString()));

        }
    }
}
