using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class EnderecoFuncionario
    {
        [Key]
        public Guid Id { get; set; }

        //utilizar o ajax para preenchimento do CEP

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Rua")]
        public string rua { get; set; }

        [Display(Name = "Nº")]
        public int numero { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Complemento")]
        public string complemento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        public UnidadeDeFederacao unidade_federacao { get; set; }

        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        public EnderecoFuncionario()
        {
            Id = Guid.NewGuid();
        }

        public EnderecoFuncionario(string rua_func, int num, string comp, string bairro_func, string cid, UnidadeDeFederacao uf, string tel)
        {
            string rua = rua_func;
            int numero = num;
            string complemento = comp;
            string bairro = bairro_func;
            string cidade = cid;
            UnidadeDeFederacao unidade_federacao = uf;
            string telefone = tel;

        }
    }
}
