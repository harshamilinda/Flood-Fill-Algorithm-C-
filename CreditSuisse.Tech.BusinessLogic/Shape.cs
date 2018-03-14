using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Shape
    {
        public IDrawable DrawUtility { get; set; }
        public Shape()
        {
            DrawUtility = new DrawUtility();
        }
        
        void Draw(List<DataLine> listOfDataLines) => DrawUtility.Draw(listOfDataLines);
    }
    
}
