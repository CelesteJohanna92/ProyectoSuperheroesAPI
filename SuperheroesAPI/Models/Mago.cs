namespace SuperheroesAPI.Models
{
    public class Mago : Superheroe
    {
        public Mago(string nombre)
        {
            Nombre = nombre;
            Tipo = "Mago";
            PoderEspecial = "Lanzar hechizos de fuego.";
            Fuerza = 7;
        }
        public override string Atacar()
        {
            return $"{Nombre} lanza una bola de fuego.";
        }
        public override string Defender()
        {
            return $"{Nombre} usa un escudo mágico para bloquear el ataque.";
        }
    }
}