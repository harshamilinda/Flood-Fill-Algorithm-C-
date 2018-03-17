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
        private IDrawable DrawUtility { get; set; }
        public Canvas() => DrawUtility = new DrawUtility();

        protected void Draw(IGeometry geometryBuilder, Dictionary<ConsoleCommand, string> instructions)
        {
            var Canvas = BusinessLogic.CanvasBuilder.GetCanvas<List<DataLine>>(instructions);
            DrawUtility.Draw(Canvas);

        }
    }
}
