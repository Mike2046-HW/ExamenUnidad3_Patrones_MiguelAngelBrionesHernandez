using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class Negrita : TextoDecorator
    {
        public Negrita(Texto texto) : base(texto) { }
        public override string texto => "\x1b[1m" + _texto.texto + "\x1b[0m";
    }
}