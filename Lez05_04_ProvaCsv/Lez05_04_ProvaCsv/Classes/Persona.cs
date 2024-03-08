using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_04_ProvaCsv.Classes
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Cf { get; set; }

        public Persona(string? nome, string? cognome, string? cf)
        {
            Nome = nome;
            Cognome = cognome;
            Cf = cf;
        }
        public override string ToString()
        {
            return "To string";
        }
        public string exportCsv()
        {
            return $"{Nome};{Cognome};{Cf}";
        }
    }
}
