using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToObjectToCsv
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public Produto()
        {
            DataCadastro = DataAtualizacao = DateTime.Now;

        }

        public Produto(string nome, int estoque, double valor)
        {
            Nome = nome;
            Estoque = estoque;
            Valor = valor;
            DataCadastro = DataAtualizacao = DateTime.Now;
        }
        public Produto(int id, string nome, int estoque, double valor)
        {
            Id = id;
            Nome = nome;
            Estoque = estoque;
            Valor = valor;
            DataCadastro = DataAtualizacao = DateTime.Now;
        }
    }
}
