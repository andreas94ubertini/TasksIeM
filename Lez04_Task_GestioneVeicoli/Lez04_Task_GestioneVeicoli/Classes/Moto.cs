using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_Task_GestioneVeicoli.Classes
{
    internal class Moto : Veicolo
    {
        public Moto(string? colore, double cilindrata, string? marca)
        {
            Colore = colore;
            Cilindrata = cilindrata;
            Marca = marca;
            Description();
        }

        private void Description()
        {
            Console.WriteLine($"Moto registrata, Colore: {Colore}, Cilindrata: {Cilindrata}CC, Marca: {Marca}");
        }
        public override string ToString()
        {
            return $"";
        }
    }
}
