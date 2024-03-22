using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.Models
{
    internal class Libro
    {
        public int LibroID { get; set; }
        public string? Titolo { get; set; }
        public DateTime? AnnoPub { get; set; }
        public bool IsDispo { get; set; }
        public Libro() { }
        public Libro(string? titolo, DateTime? annoPub, bool isDispo)
        {
            Titolo = titolo;
            AnnoPub = annoPub;
            IsDispo = isDispo;
        }
        public Libro(int libroID, string? titolo, DateTime? annoPub, bool isDispo)
        {
            LibroID = libroID;
            Titolo = titolo;
            AnnoPub = annoPub;
            IsDispo = isDispo;
        }
    }
}
