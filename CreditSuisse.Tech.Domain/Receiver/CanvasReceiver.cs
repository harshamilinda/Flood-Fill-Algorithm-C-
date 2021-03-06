﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.BusinessLogic;
using CreditSuisse.Tech.Entities;

namespace CreditSuisse.Tech.CommandHandler
{
    public class CanvasReceiver : IReceiver
    {
        public CanvasReceiver() { }
        public void Action(Dictionary<ConsoleCommand, string> instructions) => new Canvas().Draw(instructions);
    }
}
