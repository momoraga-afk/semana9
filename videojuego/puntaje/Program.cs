/*Puntajes de un Videojuego
Un jugador desea almacenar los puntajes obtenidos en diferentes partidas.

El programa debe:
Pedir al usuario ingresar 6 puntajes.
Guardar los datos en un arreglo unidimensional.
Mostrar el puntaje más alto.
Ordenar los puntajes de menor a mayor.
Contar cuántos puntajes son mayores a 500.*/

int[] puntajes = new int[6];
for (int i = 0; i < puntajes.Length; i++)
try
{
    Console.Write($"Ingrese el puntaje {i + 1}: ");
    puntajes[i] = int.Parse(Console.ReadLine()!); 
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: Ingrese un número válido.");
    i--;
    Console.ResetColor(); 
}
int puntajeMaximo = puntajes[0];
foreach (int puntaje in puntajes)
{
    if (puntaje > puntajeMaximo)
    {
        puntajeMaximo = puntaje;
    }
}
Console.WriteLine($"\nEl puntaje más alto es: {puntajeMaximo}");
Array.Sort(puntajes);
Console.WriteLine("\nPuntajes ordenados de menor a mayor:");
foreach (int puntaje in puntajes)
{
    Console.Write($"{puntaje} ");
}
Console.WriteLine();
int contador = 0;
foreach (int puntaje in puntajes)
{
    if (puntaje > 500)
    {
        contador++;
    }
}
Console.WriteLine($"\nCantidad de puntajes mayores a 500: {contador}");

