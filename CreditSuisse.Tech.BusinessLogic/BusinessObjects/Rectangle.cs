using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Rectangle : Shape
    {
        public Rectangle() : base()
        {
        }
        public void DrawRectangle(Dictionary<ConsoleCommand, string> instructions)
        {
            IGeometry RectangleBuilder = new RectangleBuilder();
            base.Draw(RectangleBuilder, instructions);
        }
    }
}
