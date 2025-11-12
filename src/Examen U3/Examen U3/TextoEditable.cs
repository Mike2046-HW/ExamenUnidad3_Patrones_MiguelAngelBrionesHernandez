using Examen_U3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U3
{
    public class TextoEditable : Texto
    {
        public string text { get; set; }
        public override string texto => text;
    }
}
