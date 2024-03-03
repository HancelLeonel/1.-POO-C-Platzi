namespace SuperHeroesApp.Models;

class AntiHeroe : SuperHeroe 
{
    public string RealizarAccionDeAntiheroe(string accion)
    {
        return $"El Antiheroe {Nombre} ha realizado: {accion}!";
    }
    
}