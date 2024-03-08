using EsercitazioneEdicola.Classes;

namespace EsercitazioneEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edicola edi = new Edicola();
            bool inserimento = true;
            while (inserimento)
            {
                Console.WriteLine("Premi 1 per gestire l'inventario, 2 per la gestione delle vendite, 9 per uscire");
                string? choice = Console.ReadLine();
                try
                { 
                    int convertedChoice = Convert.ToInt32(choice);
                    switch(convertedChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Premi 1 per inserire una pubblicazione, 2 per vedere la lista, 3 per modificare quantità o eliminare");
                                int menuChoice = Convert.ToInt32(Console.ReadLine());
                                if(menuChoice == 1) { 
                                Console.WriteLine("Che tipo di pubblicazione vuoi inserire?");
                                string? tipo = Console.ReadLine();
                                    if (tipo.Equals("giornale"))
                                    {
                                        Console.WriteLine("Inserisci Prezzo giornale");
                                        int prezzo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Inserisci Codice giornale");
                                        string? codice = Console.ReadLine();
                                        Console.WriteLine("Inserisci la quantità di stock del giornale");
                                        int stockQt = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Inserisci Redazione giornale");
                                        string? redazione = Console.ReadLine();
                                        Console.WriteLine("Ha un inserto?, -1-Si -2-No");
                                        int inputInserto = Convert.ToInt32(Console.ReadLine());
                                        bool? hasInserto;
                                        if (inputInserto == 1)
                                        {
                                            hasInserto = true;
                                        }
                                        else if (inputInserto == 2)
                                        {
                                            hasInserto = false;
                                        }
                                        else
                                        {
                                            hasInserto = null;
                                        }
                                        Pubblicazione g = new Giornale(prezzo, codice, stockQt, redazione, hasInserto);
                                        edi.addToMagazzino(g);

                                    }
                                    else if (tipo.Equals("rivista"))
                                    {
                                        Console.WriteLine("Inserisci Prezzo rivista");
                                        int prezzo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Inserisci Codice rivista");
                                        string? codice = Console.ReadLine();
                                        Console.WriteLine("Inserisci la quantità di stock della rivista");
                                        int stockQt = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Inserisci Titolo rivista");
                                        string? titolo = Console.ReadLine();
                                        Console.WriteLine("Inserisci Categoria rivista");
                                        string? categoria = Console.ReadLine();
                                        Pubblicazione p = new Rivista(prezzo, codice, stockQt, titolo, categoria);
                                        edi.addToMagazzino(p);
                                    }

                                }
                                else if(menuChoice == 2)
                                {
                                    int count = 0;
                                    foreach (Pubblicazione p in Edicola.Magazzino)
                                    {
                                        if (p.GetType() == typeof(Giornale))
                                        {
                                            Giornale temp = (Giornale)p;
                                            temp.Deatils();
                                        }
                                        else if (p.GetType() == typeof(Rivista))
                                        {
                                            Rivista temp = (Rivista)p;
                                            temp.Deatils();

                                        }
                                        count++;
                                    }
                                }
                                else if (menuChoice == 2)
                                {
                                    Console.WriteLine("Inserisci il codice della pubblicazione");
                                    string? cod = Console.ReadLine();
                                    Pubblicazione selected = Edicola.Magazzino.Find(p => p.Codice == cod);
                                    Console.WriteLine($"Elemento selezionato- {selected.Codice}");
                                }
                                break;
                            }
                    }

                }catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
