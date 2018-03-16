using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public sealed class Canvas
    {
        private static readonly Lazy<Canvas> lazy =
            new Lazy<Canvas>(() => new Canvas());

        public static Canvas Instance { get { return lazy.Value; } }
        private List<DataLine> CanvasContext { get; set; }
        private static string Instructions;
        private Canvas()
        {
            Console.WriteLine("Initiated Canvas");
            BuildCanvas(Instructions);
        }
        private void BuildCanvas(string instructions)
        {
            //TODO: imlement proper code for canvas build
            CanvasContext = new List<DataLine> {

                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
                new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },

            };
        }
        public static T GetCanvas<T>(string instructions) where T : List<DataLine>, new()
        {
            Instructions = instructions;
            return Instance.CanvasContext as T;


        }
    }

}
