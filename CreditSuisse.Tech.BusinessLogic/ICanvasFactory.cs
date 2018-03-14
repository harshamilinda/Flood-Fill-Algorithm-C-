using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    interface ICanvasFactory 
    {
       T BuildCanvas<T>()  where T : List<DataLine>, new();
    }
}
