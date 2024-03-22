using Paninoteca.Classes;

namespace Paninoteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionePaninotica g = new GestionePaninotica();
            Panino pUno = new Panino("Panino 1", "Descrizione 1", 12.5, false);
            Panino pDue = new Panino("Panino 2", "Descrizione 2", 8.5, true);
            Panino pTre = new Panino("Panino 3", "Descrizione 3", 10.5, false);
            Panino pQuattro = new Panino("Panino 4", "Descrizione 4", 5.5, true);
            g.AddPanino(pUno);
            g.AddPanino(pDue);
            g.AddPanino(pTre);
            g.AddPanino(pQuattro);
            g.GetAll();
            g.Description();
            g.GetVegan();
            g.CountAll();
            g.AveragePrice();
            
        }
    }
}
