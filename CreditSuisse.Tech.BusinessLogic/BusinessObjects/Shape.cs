using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class Shape
    {
        private IDrawable DrawUtility { get; set; }
        public Shape() => DrawUtility = new DrawUtility();

        protected void Draw(IGeometry geometryBuilder, Dictionary<ConsoleCommand, string> instructions)
        {
            var Canvas = BusinessLogic.CanvasBuilder.GetCanvas<List<DataLine>>(instructions);
            if (Canvas == null) throw new Exception("Please create a new canvas");
            var Geomatry = geometryBuilder.BuildGeometry(Canvas, instructions);
            DrawUtility.Draw(Geomatry);
        }


    }

}
