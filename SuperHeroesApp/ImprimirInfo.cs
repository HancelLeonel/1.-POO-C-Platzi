using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp;

internal class ImprimirInfo
{
    public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
    {
        Console.WriteLine($"El id es{superHeroe.Id}, " +
                          $"el Nombre es{superHeroe.Nombre}, " +
                          $"La Identidad Secreta es: {superHeroe.IdentidadSecreta}");
    }
}