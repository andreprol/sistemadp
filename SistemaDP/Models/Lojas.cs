using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Lojas
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "A descrição da instrução é obrigatória")]
        [Display(Name = "Nome da loja - descrição")]
        public string descricao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Sigla")]
        public string sigla { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Razão Social")]
        public string razao_social { get; set; }

        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public string inscricao_estadual { get; set; }

        [Display(Name = "Cód Amil")]
        public string cod_amil { get; set; }

        public EnderecoLojas endereco_lojas { get; set; }

        public Lojas()
        {
            Id = Guid.NewGuid();
        }
    }
}
