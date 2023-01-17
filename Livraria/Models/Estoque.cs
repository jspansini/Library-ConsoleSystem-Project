using Livraria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Estoque
    {
        public List<IProduto> ProdutosEmEstoque { get; set; } = new List<IProduto>();

        public void RegistrarProduto(IProduto produto)
        {
            ProdutosEmEstoque.Add(produto);
            Console.WriteLine($"O produto {produto.Titulo} foi adicionado.");
        }

        //TODO implementar acoes
        public void ConsultarEstoque()
        {

        }

        //TODO implementar parametros
        public void RealizarVenda()
        {

        }
    }
}
