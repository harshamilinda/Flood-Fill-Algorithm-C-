using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Shape
    {
        public IDrawable CaractorPrinter { get; set; }
        public Shape()
        {
            CaractorPrinter = new DrawUtility();
        }
        void Draw(List<DataLine> listOfDataLines) => CaractorPrinter.Draw(listOfDataLines);
    }
}
