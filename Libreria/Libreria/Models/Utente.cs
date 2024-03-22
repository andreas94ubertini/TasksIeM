using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    internal class Utente
    {
        public int UtenteID { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }

        public Utente() { }
        public Utente(string? nome, string? cognome, string? email)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
        }
        public Utente(int utenteID, string? nome, string? cognome, string? email)
        {
            UtenteID = utenteID;
            Nome = nome;
            Cognome = cognome;
            Email = email;
        }
    }
}
