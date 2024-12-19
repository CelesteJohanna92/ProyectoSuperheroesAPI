using SuperheroesAPI.Models;

namespace SuperheroesAPI.Factories
{
    public static class SuperheroeFactory
    {
        public static Superheroe CrearSuperheroe(string tipo, string nombre)
        {
            return tipo.ToLower() switch
            {
                "mago" => new Mago(nombre),
                "guerrero" => new Guerrero(nombre),
                "arquero" => new Arquero(nombre),
                _ => throw new ArgumentException("Tipo de superhéroe no válido.")
            };
        }
    }
}