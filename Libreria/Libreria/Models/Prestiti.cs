using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.Models
{
    internal class Prestiti
    {
        public int PrestitoID { get; set; }
        public Date? DataInizio { get; set; }
        public Date? DataFine { get; set; }
        public int UtenteRIF { get; set; }
        public int LibroRIF { get; set; }

    }
}
