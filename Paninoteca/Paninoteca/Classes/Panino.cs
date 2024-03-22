using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paninoteca.Classes
{
    internal class Panino
    {
        public int PaninoID {  get; set; }
        public string? Nome { get; set; }
        public string? Descrizione {  get; set; }
        public double Prezzo {  get; set; }
        public bool IsVegan {  get; set; }

        public Panino() { }
        public Panino(string? nome, string? descrizione, double prezzo, bool isVegan)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            IsVegan = isVegan;
        }
    }
}
