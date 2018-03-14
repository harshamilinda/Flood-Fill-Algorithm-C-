using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Line : Shape
    {
        public Line() : base()
        {
                
        }
        public void DrawLine(string command)
        {
            IGeometry LineBuilder = new LineBuilder();
            base.DrawUtility.FormatCommandText(command);
            //base.DrawUtility.Draw()
        }
    }
}
