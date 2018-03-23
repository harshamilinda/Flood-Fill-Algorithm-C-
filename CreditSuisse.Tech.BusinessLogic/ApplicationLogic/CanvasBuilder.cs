using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public sealed class CanvasBuilder
    {
        private static readonly Lazy<CanvasBuilder> lazy = new Lazy<CanvasBuilder>(() => new CanvasBuilder());

        public static CanvasBuilder Instance { get { return lazy.Value; } }
        private List<DataLine> CanvasContext { get; set; }
        private static Dictionary<ConsoleCommand, string> Instructions;
        private CanvasBuilder() => BuildCanvas(Instructions);

        private void BuildCanvas(Dictionary<ConsoleCommand, string> instructions)
        {
            var X1 = int.Parse(instructions[ConsoleCommand.X1].ToString()) + 2;
                var Y1 = int.Parse(instructions[ConsoleCommand.Y1].ToString());

                CanvasContext = new List<DataLine> { };
                CanvasContext.Add(new DataLine { Line = new StringBuilder().Insert(0, Constants.CANVASHORIZONTALLINE.ToString(), X1) });
                Y1.Times(() => CanvasContext.Add(new DataLine
                {
                    Line = new StringBuilder()
                                .Insert(0, Constants.CANVASVERTICALLINE)
                                .Insert(1, " ", X1 - 2).Insert(X1 - 1, Constants.CANVASVERTICALLINE)
                }));
                CanvasContext.Add(new DataLine { Line = new StringBuilder().Insert(0, Constants.CANVASHORIZONTALLINE.ToString(), X1) });
           
        }
        public static T GetCanvas<T>(Dictionary<ConsoleCommand, string> instructions) where T : List<DataLine>, new()
        {
            if (instructions[ConsoleCommand.ObjectType].ToString() == ActionType.C.ToString())
                Instructions = instructions;
            return Instance.CanvasContext as T;

        }
       
    }

}
