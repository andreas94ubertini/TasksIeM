using Microsoft.EntityFrameworkCore;
using TaskUni.Models;


namespace TaskUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variazione variazione = new Variazione()
            {
                ProdottoRif = 2,
                Colore = "Juan Jesus",
                Qt = 1,
                Taglia = "XXL",


            };

            using (var db = new AbbigliamentoTaskContext())
            {
                db.Variaziones.Add(variazione);
                
                db.SaveChanges();
            }
        }
    }
}
