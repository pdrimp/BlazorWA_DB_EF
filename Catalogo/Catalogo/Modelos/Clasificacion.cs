namespace Catalogo.Modelos
{
    public class Clasificacion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        //Propiedad de navegación EF
        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
