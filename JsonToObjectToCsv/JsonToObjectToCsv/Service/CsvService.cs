using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonToObjectToCsv
{
    public static class CsvService
    {
        public static bool CriaArquivoCsv(List<Produto> listaProdutos)
        {
            try
            {
                string filePath = @"D:\Dados\produtos.csv";
                List<string> linhas = new List<string>();
                string linha = $"Id;Nome;Estoque;Valor;Data de Cadastro;Data de Atualização";
                linhas.Add(linha);
                long count = 1;
                foreach (var prod in listaProdutos)
                {
                    linha = $"{prod.Id};{prod.Nome};{prod.Estoque};{prod.Valor};{prod.DataCadastro};{prod.DataAtualizacao}";
                    linhas.Add(linha);
                    Console.WriteLine($"Registro {count} pronto para salvar no arquivo CSV");
                    count++;
                }
                Console.WriteLine("Dados prontos para salvar no arquivo CSV. Por favor aguarde...");
                File.WriteAllLines(filePath, linhas, Encoding.UTF8);
                Console.WriteLine("Dados salvos com sucesso no arquivo CSV!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao criar o arquivo CSV: " + ex.Message);
                return false;
            }
        }
    }
}
