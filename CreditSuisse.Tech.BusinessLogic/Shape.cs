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
        private ICommand CommandBuilder { get; set; }
        
        public Shape()
        {
            DrawUtility = new DrawUtility();
            CommandBuilder = new CommandBuilder();
        }

        public void Draw(IGeometry geometryBuilder,string[] commands)
        {
            //TODO: Optimize
           
            var Canvas = CanvasBuilder.GetCanvas<List<DataLine>>(commands[0]);
            var Instructions  = CommandBuilder.GetInstructions(commands[1]);
            var Geomatry = geometryBuilder.BuildGeometry(Canvas, Instructions);

            DrawUtility.Draw(Geomatry);

        }

     
    }
    
}
