using Lez04_10_Task.Classes;

namespace Lez04_10_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * Creare un sistema che mantenga traccia degli oggetti contenuti nelle stanze 
               * della vostra casa.
               * Di ogni oggetto voglio conoscere:
               * - Nome
               * - Descrizione
               * - Valore dell'oggetto
               * 
               * Di ogni stanza voglio conoscere il nome
               */

            Oggetto og1 = new Oggetto() {
                NomeOggetto = "Letto",
                DescrizioneOggetto = "Comfortevole",
                ValoreOggetto = 1000.0d
            };
            Oggetto og2 = new Oggetto()
            {
                NomeOggetto = "Comodino",
                DescrizioneOggetto = "Utile",
                ValoreOggetto = 350.0d
            };
            Oggetto og3 = new Oggetto()
            {
                NomeOggetto = "Televisione",
                DescrizioneOggetto = "Led",
                ValoreOggetto = 750.0d
            };

            Stanza s = new Stanza() { 
                Name = "Camera"
            };
            s.AddOggetto(og1);
            s.AddOggetto(og2);
            s.AddOggetto(og3);
            s.DettaglioStanza();
        }
    }
}
