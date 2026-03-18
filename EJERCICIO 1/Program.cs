// See https://aka.ms/new-console-template for more information
List<Estudiante> estudiantes = new List<Estudiante>();
Console.WriteLine("Cuantos estudiantes desea ingresar ?");
int num = int.Parse(Console.ReadLine());
for (int i =0; i< num; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"Ingrese datos del estudiante {i+1}");
    Console.WriteLine($"\nIngrese nombre del estudiante {i + 1}");e.Nombre = Console.ReadLine();
    Console.WriteLine($" escriba nota 1 : ");e.Nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine($" escriba nota 2 : "); e.Nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine($" escriba nota 3 : "); e.Nota3 = double.Parse(Console.ReadLine());
estudiantes .Add(e);
}
Estudiante mejorrendimiento = estudiantes[0];
double sumadepromedios=0;
Console.WriteLine("\nDatos regisstrados:");
foreach (Estudiante d in estudiantes)
{
    d.MostrarDatosEtudiantes();
    sumadepromedios =+ d.NotaPromedio();
    if (d.NotaPromedio()> mejorrendimiento.NotaPromedio()) { mejorrendimiento = d; }
}
Console.WriteLine($"el promedio general es : {sumadepromedios:F2}");
Console.WriteLine($"el mejor promedio es: {mejorrendimiento.NotaPromedio()} y pertenece a : {mejorrendimiento.Nombre}");
class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;
    public double NotaPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
    public string Aprobado()
    {
        if (NotaPromedio() < 60) return "reprobado";
        else return "aprobado";
    }
    public void MostrarDatosEtudiantes()
    {
        Console.WriteLine($" Nombre del estudiante: {Nombre}   | \nNota primer semestre: {Nota1} | \nNota segundo  semestre: {Nota2} |\nNota tercer semestre: {Nota3}| \nPromedio: {NotaPromedio():F2}  ");
    }
}

