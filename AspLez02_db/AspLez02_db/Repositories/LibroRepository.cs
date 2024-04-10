using AspLez02_db.Models;

namespace AspLez02_db.Repositories
{
    public class LibroRepository : IRepository<Libro>
    {
        private static LibroRepository? istanza;
        public static LibroRepository GetIstanza()
        {
            if (istanza == null)
                istanza = new LibroRepository();
            
            return istanza;
             
        }

        private LibroRepository() { }

        public bool Delete(Libro t)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll()
        {
            List<Libro> lista = new List<Libro>();
            using(AccLez29LibreriaContext ctx = new AccLez29LibreriaContext())
            {
                lista = ctx.Libros.ToList();
            }
            return lista;
        }

        public Libro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Libro t)
        {
            throw new NotImplementedException();
        }
        public Libro? GetByCod (string s)
        {
            Libro? l = null;
            using(AccLez29LibreriaContext ctx = new AccLez29LibreriaContext())
            {
               l = ctx.Libros.FirstOrDefault(l => l.Codice == s);
            }
            return l;
        }
    }
}
