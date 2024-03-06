using System.Diagnostics;

namespace TaskCdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stuUno = { "Giovanni Pace", "12345", "PCAGNN" };
            //string[] stuDue = { "Valeria Verdi", "12346", "VLRVRD" };
            //string[] stuTre = { "Mario Rossi", "12347", "MRRRSS" };

            //string[][] elenco = { stuUno, stuDue, stuTre };

            //Console.WriteLine("Inserisci il codice fiscale da ricercare");
            //string? toSearch = Console.ReadLine();



            //for(int i = 0; i < elenco.Length; i++)
            //{

            //    if (elenco[i][2].ToLower().Equals(toSearch?.ToLower().Trim()))
            //            Console.WriteLine($"Nome: {elenco[i][0 ]}");

            //}

            //Titolo - AUTORE - ISBN - Casa Editrice
            string[] libro_1 = { "Il signore degli anelli", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_2 = { "Il ritorno del re", "JRRT", "123456-1226", "Casa ed 1" };
            string[] libro_3 = { "Il visconte dimezzato", "I.Calvino", "987456-1225", "Casone editrice" };
            string[] libro_4 = { "Storia del buongiorno", "A. Christie", "456466-1225", "Casone editrice" };
            string[] libro_5 = { "Le due torri", "JRRT", "456463-1225", "Casa ed 1" };

            string[][] store = { libro_1, libro_2, libro_3, libro_4, libro_5 };

            //Contare tutti i libri di JRRT o di un autore inserito a mano.        

            Console.WriteLine("Premi 1 per vedere i libri di JRRT oppure 2 per inserirne uno a mano");
            string? choice = Console.ReadLine();
            try
            {
                int counter = 0;
                int convertedChoice = Convert.ToInt32(choice);
                if (convertedChoice == 1)
                {
                    for (int i = 0; i < store.Length; i++)
                    {
                        if (store[i][1].ToUpper().Equals("JRRT"))
                            counter++;

                    }
                    Console.WriteLine($"Il numero di libri scritti da JRRT é di {counter}");
                }


                else if (convertedChoice == 2)
                {
                    Console.WriteLine("Inserisci l'autore da cercare");
                    string? author = Console.ReadLine();
                    for (int i = 0; i < store.Length; i++)
                    {
                        if (store[i][1].ToUpper().Equals(author?.ToUpper()))
                            counter++;

                    }
                    Console.WriteLine($"Il numero di libri scritti da {author} é di {counter}");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Programma finito");
            }


        }
    }
}
