using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.BusinessLogic
{
    public class DrawUtility : IDrawable
    {
        public void Draw<T>(T listOfEntities) where T : List<DataLine>, new()
        {
            listOfEntities.ForEach(item => Console.WriteLine(item.Line));
            Console.Read();
            
        }

        
    }
}
