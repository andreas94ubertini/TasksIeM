using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEdicola.Classes
{
    internal class Edicola
    {
        public string? Indirizzo { get; set; }
        public string? Nome { get; set; }
        public static List<Pubblicazione> Magazzino { get; set; } = new List<Pubblicazione>();
        
        public Edicola() { }
        public void addToMagazzino(Pubblicazione p)
        {
            Magazzino.Add(p);
        }
        public void deleteFromMagazzino(Pubblicazione p)
        {
            Magazzino.Remove(p);
        }
    }
}
