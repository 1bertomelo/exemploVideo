using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploVideo1.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string imagem { get; set; }
        public decimal precoVenda { get; set; }
        public decimal precoCusto { get; set; }
        public int estoque { get; set; }
        public int idCategoria { get; set; }
    }
}
