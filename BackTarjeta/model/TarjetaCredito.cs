using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackTarjeta.model
{
    public class TarjetaCredito
    {
        public int id { get; set; }

        [Required]//<- esto hace que el campo sea obligatorio en la bd
        public string titulo { get; set; }
        [Required]
        public string Tarjeta { get; set; }
        [Required]
        public string fechaexpiracion { get; set; }
        [Required]
        public int cvv { get; set; }
    }
}
