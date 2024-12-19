using System.ComponentModel.DataAnnotations;

namespace SuperheroesAPI.Request
{
    public class VisitarEnfermeriaRequest
    {
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int SaludActual { get; set; }
        [Required]
        public int Veces { get; set; }
    }
}
