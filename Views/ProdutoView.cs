using System.Collections.Generic;
using Aula34MVCConsole.Models;

namespace Aula34MVCConsole.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista)
            {
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}