namespace Lez02_06_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inserimento = true;
            string? lista = "";
            int index = 0;
                while (inserimento)
                {
                    Console.WriteLine("Inserisci nome invitato");
                    string? nome = Console.ReadLine();
                    Console.WriteLine("Inserisci cognome invitato");
                    string? cognome = Console.ReadLine();
                    lista += nome + " " + cognome + ",";
                    Console.WriteLine("Premi 2 per concludere, oppure 1 per continuare");
                    string? choice = Console.ReadLine();
                try
                {
                    int convertedChoice = Convert.ToInt32(choice);
                    if (convertedChoice == 2)
                    {
                        Console.WriteLine("Finito");
                        Console.WriteLine(lista);
                        inserimento = false;
                    }
                    else if (convertedChoice == 1)
                    {
                        index++;
                    }   

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                }

                
            
        }
    }
}
