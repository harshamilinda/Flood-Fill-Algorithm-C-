using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Canvas 
    {
        private List<DataLine> CanvasContext { get; set; }
        private string Instructions { get; set; }

        private Canvas(string instructions)
        {
            if (CanvasContext == null || Instructions != instructions)
            {
                BuildCanvas(instructions);
            }
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
            return new Canvas(instructions).CanvasContext as T;

           
        }


    }
}
