using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Line : Shape
    {
        public Line() : base()
        {
                
        }
        public void DrawLine(Dictionary<ConsoleCommand, string> instructions)
        {
            IGeometry LineBuilder = new LineBuilder();
            base.Draw(LineBuilder, instructions);
        }
    }
}
