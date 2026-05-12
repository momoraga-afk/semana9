/*Inventario de una Librería
Una librería necesita registrar las ventas de libros por categoría.

El programa debe:
Solicitar la cantidad de libros vendidos en 5 categorías.
Guardar la información en un arreglo.
Mostrar el total de libros vendidos.
Indicar la categoría con más ventas.
Calcular el promedio de ventas.*/

int[] ventas = new int[5];
string[] categorias = { "Ficción", "No Ficción", "Ciencia", "Historia", "Infantil" };
int totalVentas = 0;
for (int i = 0; i < ventas.Length; i++)
try
{
    Console.Write($"Ingrese la cantidad de libros vendidos en la categoría {categorias[i]}: ");
    ventas[i] = int.Parse(Console.ReadLine()!);
    totalVentas += ventas[i];
}
catch (FormatException)
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
    i--; // Decrementar el índice para volver a solicitar la entrada
}
int categoriaMasVendidaIndex = 0;
for (int i = 1; i < ventas.Length; i++)
{
    if (ventas[i] > ventas[categoriaMasVendidaIndex])
    {
        categoriaMasVendidaIndex = i;
    }
}
double promedioVentas = (double)totalVentas / ventas.Length;
Console.WriteLine($"\nTotal de libros vendidos: {totalVentas}");
Console.WriteLine($"Categoría con más ventas: {categorias[categoriaMasVendidaIndex]}");
Console.WriteLine($"Promedio de ventas: {promedioVentas:F2}");