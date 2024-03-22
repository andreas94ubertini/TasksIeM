using Libreria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DAL
{
    internal class PrestitiDal : IDal<Prestiti>
    {
        static PrestitiDal? instance;

        public static PrestitiDal getInstance()
        {
            if (instance == null)
                instance = new PrestitiDal();

            return instance;
        }
        private PrestitiDal() { }
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prestiti> findAll()
        {
            throw new NotImplementedException();
        }

        public Prestiti findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Prestiti t)
        {
            throw new NotImplementedException();
        }

        public bool update(Prestiti t)
        {
            throw new NotImplementedException();
        }
    }
}
