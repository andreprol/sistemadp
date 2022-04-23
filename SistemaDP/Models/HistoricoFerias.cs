using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class HistoricoFerias
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de início é obrigatória")]
        [Display(Name = "Data de início")]
        public DateTime datainicio { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de fim é obrigatória")]
        [Display(Name = "Data de fim")]
        public DateTime datafim { get; set; }

        [Display(Name = "Data de gozo")]
        public DateTime datagozo { get; set; }

        [Required(ErrorMessage = "O valor das férias é obrigatório")]
        [Display(Name = "Valor das férias")]
        public int valorferias { get; set; }

        [Display(Name = "Valor do abono")]
        public int abonoferias { get; set; }

        [Display(Name = "Qtd dias de gozo")]
        public int diasgozo { get; set; }

        [Display(Name = "Qtd dias vendidos")]
        public int diasvendidos { get; set; }

        [Display(Name = "Valor vendido")]
        public int valorvendido { get; set; }

        public HistoricoFerias()
        {
            Id = Guid.NewGuid();
        }
        public HistoricoFerias(DateTime dinicio, DateTime dfim, DateTime dgozo, int valor, int abono, int diasg, int diasv, int valorv)
        {
            DateTime datainicio = dinicio;
            DateTime datafim = dfim;
            DateTime datagozo = dgozo;
            int valorferias = valor;
            int abonoferias = abono;
            int diasgozo = diasg;
            int diasvendidos = diasv;
            int valorvendido = valorv;
        }
    }
}
