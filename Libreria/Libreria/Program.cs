using Libreria.DAL;
using Libreria.Models;
using Libreria.Utilities;

namespace Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Libro lib = new Libro("Titolo", new DateTime(2023,03,12),true);
            LibroDal.getInstance().insert(lib);

        }
    }
}
