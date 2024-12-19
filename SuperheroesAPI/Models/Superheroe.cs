namespace SuperheroesAPI.Models
{
    public abstract class Superheroe
    {  
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5; // Salud máxima inicial

        public abstract string Atacar(); 
        public abstract string Defender(); 
    }
}

