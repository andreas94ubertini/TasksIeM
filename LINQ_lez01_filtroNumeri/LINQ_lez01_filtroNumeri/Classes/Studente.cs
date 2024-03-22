using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lez01_filtroNumeri.Classes
{
    internal class Studente
    {
        public string? Nominativo { get; set; }
        public int Eta { get; set; }
        public string? Matricola { get; set; }
        public Studente() { }
        public Studente(string? nominativo, int eta, string? matricola)
        {
            Nominativo = nominativo;
            Eta = eta;
            Matricola = matricola;
        }
    }
}
