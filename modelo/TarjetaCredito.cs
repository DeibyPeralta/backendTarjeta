using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backendTarjeta.modelo
{
    public class TarjetaCredito
    {
        [Key] // le digo a entity framework que id es la primary key
        public int Id { get; set; }

        [Required] // campos requeridos
        public string titular { get; set; }
        [Required]
        public string numeroTarjeta { get; set; }
        [Required]
        public string fechaExpiracion { get; set; }
        [Required]
        public string cvv { get; set; }
    }
}
