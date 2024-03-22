using TaskLinq.Classes;

namespace TaskLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Prodotti = new List<Product>() {
                new Product("Prodotto 1","Descrizione 1",12.5f,"Elettronica", 5),
                new Product("Prodotto 2","Descrizione 2",10.2f,"Arredamento", 15),
                new Product("Prodotto 3","Descrizione 3",8.5f,"Gaming", 9),
                new Product("Prodotto 4","Descrizione 4",5.5f,"Elettronica", 8)
            };

            var prodottiCategoria = from p in Prodotti
                                    where p.Categoria is not null && p.Categoria.Equals("Elettronica")
                                    select p;
            foreach(var item in prodottiCategoria)
            {
                Console.WriteLine($"{item.Nome}");
            }
            Console.WriteLine($"Prezzo medio: {Prodotti.Average(p =>p.Prezzo)}");
            var GroupByNum = from p in Prodotti
                             group p by p.Categoria into contenitoreCat
                             select contenitoreCat;
            foreach ( var p in GroupByNum) {
                Console.WriteLine($"Prodotti dentro {p.Key}: {p.Count()}");
            }

            float totalValue = 0;
            foreach(var p in Prodotti)
            {
                totalValue += p.Prezzo * p.Qt;
            }

            Console.WriteLine(totalValue);
            
        }
    }
}
