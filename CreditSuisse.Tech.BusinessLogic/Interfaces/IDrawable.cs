using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public interface IDrawable
    {
        void Draw<T>(T listOfDataLines) where T : List<DataLine>, new();
    }
}
