using System;
using System.Collections.Generic;

namespace JsonToObjectToCsv
{
    public static class ListService
    {
        public static void ImprimeProdutosDaLista(List<Produto> listProdutos)
        {
            Console.WriteLine(" --- DADOS DA LISTA DE PRODUTOS ---");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var prod in listProdutos)
            {
                Console.WriteLine($"ID: {prod.Id} | Nome: {prod.Nome} - Estoque: {prod.Estoque} |  Valor: R$ {prod.Valor} | Data de Cadastro: {prod.DataCadastro} | Última Atualização: {prod.DataAtualizacao}");
            }
            Console.WriteLine("=======================================================");
        }
    }
}