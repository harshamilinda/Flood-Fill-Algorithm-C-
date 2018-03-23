using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Tech.Entities
{
    public static class Constants
    {
        public const char CANVASVERTICALLINE = '|';
        public const char CANVASHORIZONTALLINE = '-';
        public const char LINECOLOUR = 'x';
        public const char CHARWHITESPACE = ' ';

        #region Program Header
        public const string CONSOLEHEADER = @"Welcome to Drawing Program !" + "\r\n" +
                                            "--------------------------" + "\r\n"; 
        #endregion
        #region Help Menu
        public const string HelpMenu =
          @"1. Create canvas" + "\t" + "C w h " + "\t\t" + 
            "Canvas of width w and height h" + "\r\n" +

          "2. New line" + "\t\t" + "L x1 y1 x2 y2" + "\t" + 
            "create a new line from (x1,y1) to (x2,y2)" + "\r\n" +

          "3. New rectangle" + "\t" + "R x1 y1 x2 y2" + "\t" + 
            "create a new rectangle, whose upper left corner is (x1, y1) and lower right corner is (x2, y2)" +
          "\r\n" +

          "4. Fill" + "\t\t\t" + "B x y c " + "\t" + 
            "Fill the entire area connected to (x,y) with colour c " + "\r\n" +

          "5. Quit" + "\t\t\t" + "Q " + "\t\t" + 
            "Quit the program" + "\r\n" + "\r\n" + 
            "Please key in your command";

        #endregion
    }
}
