using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSuisse.Tech.Entities;


namespace CreditSuisse.Tech.BusinessLogic
{
    public static class Extentions
    {
        //Loop Utilities
        public static void Times(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }

        //Casting
        public static int ToInt(this string value)
        {
           return int.Parse(value);
        }

        public static Dictionary<Axis, int> GetPositions(this Dictionary<ConsoleCommand, string> instructions)
        {
            if (instructions.IsFillCommand())
            {
                return new Dictionary<Axis, int>()
                {
                    {Axis.X1,instructions[ConsoleCommand.X1].ToInt()},
                    {Axis.Y1,instructions[ConsoleCommand.Y1].ToInt() }
                    
                };
            }
            else
            {
                return new Dictionary<Axis, int>()
                {
                    {Axis.X1,instructions[ConsoleCommand.X1].ToInt()-1 },
                    {Axis.Y1,instructions[ConsoleCommand.Y1].ToInt() },
                    {Axis.X2,instructions[ConsoleCommand.X2].ToInt()-1 },
                    {Axis.Y2,instructions[ConsoleCommand.Y2].ToInt() }
                };
            }

           
          
        }
        public static bool IsFillCommand(this string value)
        {
            return !int.TryParse(value, out int Y2);
        }
        public static bool IsFillCommand(this Dictionary<ConsoleCommand, string> instructions)
        {
            return instructions.ContainsKey(ConsoleCommand.Colour);
        }
    }
    
}
