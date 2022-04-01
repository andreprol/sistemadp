using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Bancos
    {
        [Key]
        public Guid Id { get; set; }

        private string numero_banco { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string descricao_banco { get; set; }

        private string agencia_banco { get; set; }

        private string  conta_banco { get; set; }

        public Bancos()
        {

        }

        public Bancos(string numero, string descricao, string agencia, string conta)
        {
            numero_banco = numero;
            descricao_banco = descricao;
            agencia_banco = agencia;
            conta_banco = conta;
        }
    }
}
