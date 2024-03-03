using System.Text;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.Id = 1;
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelTres;

var superFuerza = new SuperPoder();
superFuerza.Id = 2;
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Fuera sobre humana";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Id = 3;
regeneracion.Nombre = "Regeneración";
regeneracion.Descripcion = "Permite regenerarse";
regeneracion.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;

string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);
wolverine.SuperPoderes = poderesWolverine;
string resultSuperPoderesWolverine = wolverine.UsarSuperPoderes(); 
Console.WriteLine(resultSuperPoderesWolverine);
Console.WriteLine(wolverine.RealizarAccionDeAntiheroe("Ataca la policía"));

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
