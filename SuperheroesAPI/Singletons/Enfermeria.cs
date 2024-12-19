namespace SuperheroesAPI.Singletons
{
    public class Enfermeria
    {
        private static readonly Lazy<Enfermeria> _instancia = new Lazy<Enfermeria>(() => new Enfermeria());
        public static Enfermeria Instancia => _instancia.Value;

        public int VisitasRestantes { get; private set; } = 5; // Límite de visitas

        private Enfermeria() { }

        public bool AtenderVisita()
        {
            return VisitasRestantes > 0 && (--VisitasRestantes >= 0);
        }

        internal static object ObtenerInstancia()
        {
            throw new NotImplementedException();
        }
    }
}