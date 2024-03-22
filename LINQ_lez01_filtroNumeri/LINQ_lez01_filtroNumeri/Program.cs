using LINQ_lez01_filtroNumeri.Classes;

namespace LINQ_lez01_filtroNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> elenco = new List<int>() { 1,4,6,8,7,10,9,-2,-45};
            ////Prendo tutti i valori > di 5
            //var risultato = from valore in elenco 
            //                where valore > 5 
            //                orderby valore
            //                select valore;
            //foreach(int item in risultato)
            //{
            //    Console.WriteLine(item);
            //}

            List<Studente> elenco = new List<Studente>() { 
                
                new Studente("Giovanni Pace", 37, "AB1234"),
                new Studente("Valeria Verdi", 35, "AB1235"),
                new Studente("Marika Mariko", 34, "AB1236")
            };
            var risultato = from stud in elenco
                            where stud.Eta > 35
                            orderby stud.Eta
                            select stud;
            foreach(var item in risultato) 
            {
                Console.WriteLine($"{item.Nominativo},{item.Matricola},{item.Eta}");
            }

            Console.WriteLine($"Età media: {elenco.Average(s=> s.Eta)}");
        }
    }
}
