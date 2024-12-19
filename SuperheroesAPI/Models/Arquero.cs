
namespace SuperheroesAPI.Models
{
    public class Arquero : Superheroe
{
    public Arquero(string nombre)
    {
        Nombre = nombre;
        Tipo = "Arquero";
        PoderEspecial = "Disparo certero a larga distancia";
        Fuerza = 6;
    }

    public override string Atacar()
    {
        return $"{Nombre} dispara una flecha precisa.";
    }

    public override string Defender()
    {
        return $"{Nombre} se mueve rápidamente para esquivar el ataque.";
    }
}
}
