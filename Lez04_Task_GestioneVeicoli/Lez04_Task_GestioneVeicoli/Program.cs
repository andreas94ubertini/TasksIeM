using Lez04_Task_GestioneVeicoli.Classes;

namespace Lez04_Task_GestioneVeicoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Creare un sistema di gestione veicoli:
              *
              * All'inserimento di un nuovo veicolo mi sia permessa la scelta tra:
              * 1. Automobile
              * 2. Moto
              *
              * Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i suoi dettagli.
              *
              * Libera scelta degli attributi
              */

            Console.WriteLine("Premi 1 per inserire un automobile, 2 per inserire una moto");
            string? choice = Console.ReadLine();
            try
            {
                int convertedChoice = Convert.ToInt32(choice);
                if(convertedChoice == 1 ){
                    Console.WriteLine("Inserisci colore automobile");
                    string? carColor = Console.ReadLine();
                    Console.WriteLine("Inserisci cilindrata");
                    string? cc = Console.ReadLine() ;
                    double carCc = Convert.ToDouble(cc);
                    Console.WriteLine("Inserisci marca");
                    string? carBrand = Console.ReadLine() ;
                    Automobile newCar = new Automobile(carBrand, carCc, carBrand);
                }else if(convertedChoice == 2)
                {
                    Console.WriteLine("Inserisci colore moto");
                    string? motoColor = Console.ReadLine();
                    Console.WriteLine("Inserisci cilindrata");
                    string? cc = Console.ReadLine();
                    double motoCc = Convert.ToDouble(cc);
                    Console.WriteLine("Inserisci marca");
                    string? motoBrand = Console.ReadLine();
                    Moto newMoto = new Moto(motoBrand, motoCc, motoBrand);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
