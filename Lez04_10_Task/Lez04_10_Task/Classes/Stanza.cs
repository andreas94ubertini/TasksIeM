using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_10_Task.Classes
{
    internal class Stanza
    {
        public string? Name { get; set; }

        private List<Oggetto> elenco = new List<Oggetto>();

        public void DettaglioStanza()
        {
            Console.WriteLine($"Nome della stanza {Name}");
            foreach( Oggetto o in elenco)
            {
                Console.WriteLine($"Nome oggetto: {o.NomeOggetto}\n " +
                    $"Descrizione oggetto: {o.DescrizioneOggetto}\n" +
                    $"Valore oggetto: {o.ValoreOggetto} Eur");

            }
        }
        public void AddOggetto(Oggetto o)
        {
            elenco.Add(o);
        }
    }
}
