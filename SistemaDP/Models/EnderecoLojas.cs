using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class EnderecoLojas
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

        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        public EnderecoLojas()
        {
            Id = Guid.NewGuid();
        }

        public EnderecoLojas(string rua_loja, int num, string comp, string bairro_loja, string cid, string tel)
        {
            string rua = rua_loja;
            int numero = num;
            string complemento = comp;
            string bairro = bairro_loja;
            string cidade = cid;
            string telefone = tel;

        }
    }
}
    

