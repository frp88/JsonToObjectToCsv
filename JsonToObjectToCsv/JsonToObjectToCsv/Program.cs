using System;
using System.Collections.Generic;

namespace JsonToObjectToCsv
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Executa a função que lê um arquivo JSON e cria uma Lista de Objetos 
            List<Produto> listaProdutos = JsonService.DesserializaListaDeProdutos();
            ListService.ImprimeProdutosDaLista(listaProdutos);

            // Executa a função que cria e escreve um arquivo CSV a partir de uma Lista e salva o arquivo em um diretório do Sistema Operacional
            CsvService.CriaArquivoCsv(listaProdutos);

            Console.ReadKey();
        }
    }
}
