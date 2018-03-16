using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Rectangle : Shape
    {
        public Rectangle() : base()
        {
        }
        public void DrawRectangle(string[] commands)
        {
            IGeometry RectangleBuilder = new RectangleBuilder();
            base.Draw(RectangleBuilder, commands);


        }
    }
}
