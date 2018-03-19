using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class PaintBucket
    {
        private IDrawable DrawUtility { get; set; }
        private IFillable FillUtility { get; set; }
        public PaintBucket()
        {
            DrawUtility = new DrawUtility();
            FillUtility = new FillUtility();
        }

        public void Fill(Dictionary<ConsoleCommand, string> instructions)
        {
            var Canvas = BusinessLogic.CanvasBuilder.GetCanvas<List<DataLine>>(instructions);
            var Geomatry = FillUtility.Fill(Canvas, instructions);
            DrawUtility.Draw(Geomatry);

        }
    }
}
