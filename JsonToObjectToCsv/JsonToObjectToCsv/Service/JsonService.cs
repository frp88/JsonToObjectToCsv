using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonToObjectToCsv {
    public static class JsonService {
        public static List<Produto> DesserializaListaDeProdutos() {
            try {
                List<Produto> listaProdutos = new List<Produto>();
                string jsonFilePatch = @"D:\Dados\jsonProdutos.json";
                string jsonProdutos = File.ReadAllText(jsonFilePatch);
                listaProdutos = JsonConvert.DeserializeObject<List<Produto>>(jsonProdutos);
                return listaProdutos;
            }
            catch (Exception ex) {
                Console.WriteLine("Falha ao ler o arquivo JSON: " + ex.Message);
                return null;
            }
        }
    }
}