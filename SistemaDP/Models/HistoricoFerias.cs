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

        public DateTime datagozo { get; set; }

        [Required(ErrorMessage = "O valor das férias é obrigatório")]
        public int valorferias { get; set; }

        public int abonoferias { get; set; }

        public int diasgozo { get; set; }

        public int diasvendidos { get; set; }

        public int valorvendido { get; set; }

        public HistoricoFerias()
        {

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
