using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToObjectToCsv {
    public class Endereco {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string UF { get; set; }

        public Endereco() { }

        public Endereco(string cep) {
            this.Cep = cep;
        }
    }
}
