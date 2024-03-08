using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEdicola.Classes
{
    internal abstract class Pubblicazione
    {
        public float Prezzo { get; set; }
        public string? Codice { get; set; }
        public int StockQt { get; set; }
        public int GetQt()
        {
            return StockQt;
        }

        public Pubblicazione() { }
        public virtual void Deatils()
        {
            Console.WriteLine($"[Pubblicazione]");
        }
       

       


    }
}
