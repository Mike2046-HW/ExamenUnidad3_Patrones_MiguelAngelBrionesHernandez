using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class Color
    {
        public void CambiarColor (ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void ReestablecerColor()
        {
            Console.ResetColor();
        }
    }
}
