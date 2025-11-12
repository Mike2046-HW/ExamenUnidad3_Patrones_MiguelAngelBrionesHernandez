using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    internal class Subrayada:TextoDecorator
    {
        public Subrayada(Texto texto) : base(texto) { }
        public override string texto => "\x1b[4m" + _texto.texto + "\x1b[0m";
    }
}
