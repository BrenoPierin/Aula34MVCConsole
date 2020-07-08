using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula34MVCConsole.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public const string PATH = "Database/Produto.csv";

        public Produto()
        {

        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach(var linha in linhas){
                
                string[] dado = linha.Split(";");

                Produto p   = new Produto();
                p.Codigo    = Int32.Parse( Separar(dado[0]) );
                p.Nome      = Separar(dado[1]);
                p.Preco     = float.Parse( Separar(dado[2]) );

                produtos.Add(p);
            }

            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos; 
        }

        private string Separar(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
        
        
    }
}