using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class EstadoCivil
    {
        [Key]
        public Guid Id { get; set; }

        public enum estadocivil { solteiro, casado, separado, divorciado, outros }

        public EstadoCivil()
        {
            Id = Guid.NewGuid();
        }

    }
}
