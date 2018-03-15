﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.BusinessLogic
{
    public interface IGeometry
    {
        T BuildGeometry<T>(T canvas, Dictionary<ConsoleCommand, char> instructions) where T : List<DataLine>, new();
        
    }
}