using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLinq.Classes
{
    internal class Product
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public float Prezzo { get; set; }
        public string? Categoria { get; set; }
        public int Qt { get; set; }

        public Product() { }
        public Product(string? nome, string? descrizione, float prezzo, string? categoria, int qt)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Categoria = categoria;
            Qt = qt;
        }
    }
}
