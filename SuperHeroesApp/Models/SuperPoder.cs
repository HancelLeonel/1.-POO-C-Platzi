namespace SuperHeroesApp.Models;

class SuperPoder
{
    public int Id;
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}
