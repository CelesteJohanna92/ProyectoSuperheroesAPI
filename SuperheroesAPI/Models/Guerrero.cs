namespace SuperheroesAPI.Models
{
    public class Guerrero : Superheroe
    {
        public Guerrero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Guerrero";
            PoderEspecial = "Golpe poderoso con espada";
            Fuerza = 9;
        }

        public override string Atacar()
        {
            return $"{Nombre} ataca con su espada.";
        }

        public override string Defender()
        {
            return $"{Nombre} levanta su escudo para defenderse.";
        }
    }
}