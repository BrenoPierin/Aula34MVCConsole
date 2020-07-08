using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string _produto)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(_produto));
            produtoView.MostrarNoConsole(lista);
            
        }
    }
}