using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Eventos
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nº Evento")]
        public int numero_evento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Descrição do Evento")]
        public string descricao_evento { get; set; }

        [Display(Name = "Data do evento")]
        public DateTime data_evento { get; set; }

        public Eventos()
        {
            Id = Guid.NewGuid();
        }

        public Eventos(string descricao, DateTime data)
        {
            string descricao_evento = descricao;
            DateTime data_evento = data;
        }
    }
}
