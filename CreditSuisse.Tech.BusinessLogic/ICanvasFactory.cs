using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public  interface ICanvasFactory 
    {
       T GetCanvas<T>(string instructions)  where T :  List<DataLine> , new();
    }
}
