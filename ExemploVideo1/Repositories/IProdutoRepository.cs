using ExemploVideo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploVideo1.Repositories
{
    public interface IProdutoRepository : IDisposable
    {
        public IList<Produto> GetAll();

        public Produto GetById(int id);

       public void Insert(Produto obj);

        public void Update(Produto obj);

        public void Remove(int id);

    }
}
