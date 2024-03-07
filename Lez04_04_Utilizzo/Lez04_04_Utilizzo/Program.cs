using Lez04_04_Utilizzo.Classes;

namespace Lez04_04_Utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
           * Creare un sistema in grado di immagazinare i dati relativi ad una persona.
           * Inoltre, sarà necessario immagazinare, all'interno di una persona, i dati 
           * relativi a:
           * - Codice Fiscale
           * |- CODICE
           * |_ Data di scadenza
           * 
           * - Carta di Identita: 
           * |- CODICE
           * |- Data di Emissione
           * |- Data di Scadenza
           * |_ Emissione (comune || zecca dello stato)
           */

            Console.WriteLine("Inserisci i dati per registrare una nuova persona");
            Console.WriteLine("Digitare Nome:");
            string? name = Console.ReadLine();
            Console.WriteLine("Digitare Cognome:");
            string? surname = Console.ReadLine();
            Console.WriteLine("Dati del codice fiscale");
            Console.WriteLine("Inserisci codice");
            string? cf = Console.ReadLine();
            Console.WriteLine("Inserisci data di scadenza");
            string? scadCf = Console.ReadLine();
            Console.WriteLine("Dati della carta di identità");
            Console.WriteLine("Inserisci codice");
            string? codCi = Console.ReadLine();
            Console.WriteLine("Data di emissione");
            string? dataEmissCi = Console.ReadLine();
            Console.WriteLine("Data di scadenza");
            string? scadCi = Console.ReadLine();
            Console.WriteLine("Da chi è stata emessa?");
            string? emissCi = Console.ReadLine();
            Persona p = new Persona()
            {
                Nome = name,
                Cognome = surname,
                Cf = new CodFiscale
                {
                    Codice = codCi,
                    DataScadenza = scadCf
                },
                Ci = new CartaId
                {
                    Codice = codCi,
                    DataEmiss = dataEmissCi,
                    DataScad = scadCi,
                    Emissione = emissCi
                    
                }
        
            };
            








        }
    }
}
