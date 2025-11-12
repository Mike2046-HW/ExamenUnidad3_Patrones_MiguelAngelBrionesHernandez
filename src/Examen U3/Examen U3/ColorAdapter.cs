using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class ColorAdapter : Texto
    {
        private readonly Texto _texto;
        private ConsoleColor _color;

        public ColorAdapter(Texto texto, ConsoleColor color)
        {
            _texto = texto;
            _color = color;
        }

        public void CambiarColor(ConsoleColor nuevoColor)
        {
            _color = nuevoColor;
        }

        public override string texto
        {
            get
            {
                Console.ForegroundColor = _color;
                return _texto.texto;
            }
        }
    }
}

