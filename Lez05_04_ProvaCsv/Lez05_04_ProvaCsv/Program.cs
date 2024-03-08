using Lez05_04_ProvaCsv.Classes;

namespace Lez05_04_ProvaCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona("Giovanni","Pace","gvcpc");
            Persona val = new Persona("Valeria","Verdi","vlrvrd");
            Persona mar = new Persona("Marika","Mariko","mrkmkr");

            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\utente\\Desktop\\persone.txt"))
                {
                    sw.WriteLine(gio.exportCsv());
                    sw.WriteLine(val.exportCsv());
                    sw.WriteLine(mar.exportCsv());
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
