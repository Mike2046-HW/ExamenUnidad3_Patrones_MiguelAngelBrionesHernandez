using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    internal class Cursiva:TextoDecorator
    {
        public Cursiva(Texto texto) : base(texto) { }
        public override string texto => "\x1b[3m" + _texto.texto + "\x1b[0m";
    }
}
