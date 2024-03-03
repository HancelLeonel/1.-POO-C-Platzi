namespace SuperHeroesApp.Models;

abstract class Heroe
{
    
    public abstract string Nombre { get; set; }
    public abstract string SalvarElMundo();

    public string SalvarLaTierra()
    {
        return $"{Nombre} ha salvado la Tierra";
    }

    public virtual string SalvarLaTierraPolimorfo()
    {
        return $"{Nombre} ha salvado la Tierra";
    }
}