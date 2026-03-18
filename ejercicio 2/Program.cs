// See https://aka.ms/new-console-template for more information
List<Producto> productos = new List<Producto>();
Console.WriteLine(" Cuantos productos desea ingresar?");
int Num= int.Parse(Console.ReadLine());
for (int i = 0; i < Num; i++)
{
    Producto P = new Producto();
    Console.WriteLine($" Ingrese los datos del producto {i + 1}");
    Console.WriteLine($"\n Ingrese el nombre del producto {i + 1}");P.NombreDelProducto = Console.ReadLine();
    Console.WriteLine($"\n Ingrese el precio del producto {i + 1}"); P.Precio = double.Parse(Console.ReadLine());
    Console.WriteLine($"\n Ingrese cantidad del producto {i + 1}"); P.Cantidad = double.Parse(Console.ReadLine());
    productos.Add(P);
}
Console.WriteLine("\nLos datos de los productos ingresados son");
double valordeinventario = 0;
Producto Productomascaro = productos[0];
foreach (Producto p in productos)
{
    p.Datos();
    valordeinventario =+p.PrecioEnINventario();
    if (p.Precio > Productomascaro.Precio) { Productomascaro = p; }
}
Console.WriteLine($"\n el valor total del inventario es : Q{valordeinventario:F2}");
Console.WriteLine($"\n el producto mas caro es {Productomascaro.NombreDelProducto} con un valor de : Q{Productomascaro.Precio:F2}");
class Producto
{
    public string NombreDelProducto;
    public double Precio;
    public double Cantidad;
    public double PrecioEnINventario()
    {
        return Precio * Cantidad;
    }
    public String Stock()
    {
        if (Cantidad == 0) return $"inexistene en inventario: {Cantidad} en existencia";
        else if (Cantidad > 25) return $"La existecia es mínima: {Cantidad} en existencia";
        else if (Cantidad >100) return $"existencia suficiente: {Cantidad} en existencia";

    }
    public void Datos ()
    {
        Console.WriteLine($" Nombre del producto : {NombreDelProducto} | Precio : Q{Precio} | Cantidad {Cantidad} | Estado {Stock()} ");
    }

}
