using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public abstract class TextoDecorator:Texto
    {
        protected Texto _texto;

        public TextoDecorator(Texto texto)
        {
            _texto = texto;
        }
    }
}
