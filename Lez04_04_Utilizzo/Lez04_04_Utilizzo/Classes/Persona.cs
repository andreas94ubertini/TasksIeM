using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_04_Utilizzo.Classes
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public CodFiscale? Cf { get; set; }
        public CartaId? Ci { get; set; }
    }
}
