using ExemploVideo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploVideo1.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IList<Produto> listaProdutos = new List<Produto>();
        public ProdutoRepository()
        {
            listaProdutos.Add(new Produto() { id = 1, descricao = "TV 1", estoque = 10, nome = "TV 1", precoCusto = 1000.99M });
            listaProdutos.Add(new Produto() { id = 2, descricao = "TV 2", estoque = 10, nome = "TV 2", precoCusto = 1000.99M });
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetAll()
        {
            return listaProdutos;

        }

        public Produto GetById(int id)
        {
          return  listaProdutos.Where(x => x.id == id).FirstOrDefault();
        }

        public void Insert(Produto obj)
        {
            listaProdutos.Add(obj);
        }

        public void Remove(int id)
        {
            var filtroProduto = listaProdutos.Where(x => x.id == id).FirstOrDefault();
            listaProdutos.Remove(filtroProduto);
        }

        public void Update(Produto obj)
        {
            throw new NotImplementedException();
        }
    }
}
