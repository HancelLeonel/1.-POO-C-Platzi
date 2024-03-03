using System.Text;

namespace SuperHeroesApp.Models;

class SuperHeroe
{
    private string _Nombre;
    public int Id;
    public string Nombre
    {
        get
        {
            return _Nombre;
        }
        set
        {
            _Nombre = value.Trim();
        }
    }

    public string NombreeIdentidadSecreta
    {
        get
        {
            return $"En la realidad {Nombre} es {IdentidadSecreta}";
        }
    }
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    public SuperHeroe()
    {
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var power in SuperPoderes)
        {
            sb.AppendLine($"{Nombre} esta usando el super poder {power.Nombre}!!");
            sb.AppendLine($"{NombreeIdentidadSecreta}");
        }
        return sb.ToString();
    }
}
