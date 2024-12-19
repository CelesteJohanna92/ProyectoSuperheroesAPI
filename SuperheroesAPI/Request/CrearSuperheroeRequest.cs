using System.ComponentModel.DataAnnotations;

namespace SuperheroesAPI.Request
{
    public class CrearSuperheroeRequest
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }
    }
}

