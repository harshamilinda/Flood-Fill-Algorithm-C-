using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    //public sealed class Canvas 
    //{
        //private static Canvas instance = null;
        
        //private static readonly object Padlock = new object();


        //private List<DataLine> CanvasContext { get; set; }
        //private static string Instructions;

        //Canvas()
        //{
        //    BuildCanvas(Instructions);
        //}

        //public static Canvas Instance
        //{
        //    get
        //    {
        //        lock (Padlock)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Canvas();
        //            }
        //            return instance;
        //        }
        //    }
        //}

        //private Canvas(string instructions)
        //{
        //    if (CanvasContext == null || Instructions != instructions)
        //    {
        //        BuildCanvas(instructions);
        //    }
        //}
        //private void BuildCanvas(string instructions)
        //{
        //    //TODO: imlement proper code for canvas build
        //    CanvasContext = new List<DataLine> {

        //        new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "|").Insert(1, " ",18).Insert(19,"|") },
        //        new DataLine{ Line= new StringBuilder().Insert(0, "-", 20) },

        //    };
        //}
        //public static T GetCanvas<T>(string instructions) where T : List<DataLine>, new()
        //{
        //    Canvas.Instructions = instructions;
        //    return new Canvas(instructions).CanvasContext as T;

           
        //}


    //}
    public sealed class Canvas
    {
        private static readonly Lazy<Canvas> lazy =
            new Lazy<Canvas>(() => new Canvas(Instructions));

        public static Canvas Instance { get { return lazy.Value; } }
        private  List<DataLine> CanvasContext { get; set; }
        private static string Instructions;
        private Canvas(string instructions)
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
