using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_U3
{
    internal class Reestablecer:TextoDecorator
    {
        public Reestablecer(Texto texto) : base(texto) { }
        public override string texto
        {
            get
            {
                string limpio = Regex.Replace(_texto.texto, @"\x1b\[[0-9;]*m", "");
                return limpio;
            }
        }

    }
}
