using System.Text;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models;

class SuperHeroe : Heroe, ISuperHeroe 
{
    private string _Nombre;
    public int Id { get; set; }
    public override string Nombre
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
    public string IdentidadSecreta { get; set; }
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

    public override string SalvarElMundo()
    {
        return $"{NombreeIdentidadSecreta} ha salvado el mundo";
    }

    public override string SalvarLaTierraPolimorfo()
    {
        //Hace lo que hace el padre más lo que está abajo
        //return base.SalvarLaTierra();
        return $"{NombreeIdentidadSecreta} ha salvado la tierra";
    }
}
