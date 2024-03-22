using db_lez06_ef.Models;

namespace db_lez06_ef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona() {
                Nome = "Osvaldo",
                Cognome = "Bevilaciqa",
                Email = "osv@wtf.it"
            };
            Cartum c = new Cartum()
            {
                Codice = "GG123",
                Negozio = "SMA",
                PersonaRifNavigation = p
            };
            Cartum cDue = new Cartum()
            {
                Codice = "TT109",
                Negozio = "Tigotà",
                PersonaRifNavigation = p
            };
            //using ( var ctx = new AccLez07OtmCartaContext() )
            //{
            //    try {

            //        ctx.Personas.Add( p );
            //        ctx.Carta.Add(c);
            //        ctx.Carta.Add(cDue);
            //        ctx.SaveChanges();

            //    }catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            
            using (var ctx = new AccLez07OtmCartaContext())
            {
                try
                {

                ICollection<Persona> elencoPer = ctx.Personas.ToList();


                }
                catch (Exception ex)
                {
                  
                }
            }
        }
    }
}
