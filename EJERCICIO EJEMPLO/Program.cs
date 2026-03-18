// See https://aka.ms/new-console-template for more information
List<DispositivosELectronico> dispositivo = new List<DispositivosELectronico>();
Console.WriteLine("Cuantos dispositivos desea agregar : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    DispositivosELectronico D = new DispositivosELectronico();
    Console.WriteLine($" dispositivo {i + 1}: ");
    Console.WriteLine($" escriba nombre del dispositivo: "); D.NombreDeldispositivo = Console.ReadLine();
    Console.WriteLine($" escriba rendimiento 1 del dispositivo: "); D.Rendimiento1 = double.Parse(Console.ReadLine());
    Console.WriteLine($" escriba rendimiento 2 del dispositivo: "); D.Rendimiento2 = double.Parse(Console.ReadLine());
    Console.WriteLine($" escriba rendimiento 3 del dispositivo: "); D.Rendimiento3 = double.Parse(Console.ReadLine());
    dispositivo.Add(D);
}

Console.WriteLine("\n datos de los dispositivos: ");
double sumadepromedios = 0;
DispositivosELectronico mejorrendimiento = dispositivo[0];
foreach (DispositivosELectronico i in dispositivo)
{
    i.MostrarDatos();
    sumadepromedios += i.CalcularPromedio();
    if (i.CalcularPromedio() > mejorrendimiento.CalcularPromedio()) { mejorrendimiento = i; }


}
Console.WriteLine($"\n \t \t el promdio general de los dispositovos igresados son : {sumadepromedios:F2}");
Console.WriteLine($"\n \t \t mejor promedio ");
mejorrendimiento.MostrarDatos();
class DispositivosELectronico
{
    public string NombreDeldispositivo;
    public double Rendimiento1;
    public double Rendimiento2;
    public double Rendimiento3;
    public double CalcularPromedio()
    {
        return (Rendimiento1 + Rendimiento2 + Rendimiento3) / 3;
    }
    public string ObtenerEstado()
    {
        if (CalcularPromedio() >= 80) return "Estado optimo";
        else return "Necesita mantenimiento";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {NombreDeldispositivo} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado():F2}");
    }
}